using System;
using System.Collections.Generic;
using System.Linq;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects;
using HomeAutomation.Helpers.Desktop.Application.Queries.Handlers;
using HomeAutomation.Helpers.Desktop.Core.Entities;
using HomeAutomation.Helpers.Desktop.Core.Repositories;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Queries.Handlers;

public class GetMultipleLabelsHandler : IGetMultipleQueryHandler<GetMultipleLabels, LabelDto>
{
    private readonly LabelRepository _labelRepository;

    public GetMultipleLabelsHandler(LabelRepository labelRepository)
    {
        _labelRepository = labelRepository;
    }

    public List<LabelDto> Handle(GetMultipleLabels command)
    {
        var predicate = GetPredicate(command);

        if (predicate is null)
        {
            return _labelRepository.GetAll().ToList();
        }
        else
        {
            return _labelRepository.GetByPredicate(predicate).ToList();
        }
    }

    private static Func<LabelEntity, bool> GetPredicate(GetMultipleLabels command)
    {
        Func<LabelEntity, bool> predicate = null;

        if (command.Ids.Count > 0)
        {
            if (command.Ids.Count == 1)
            {
                var id = command.Ids[0];

                predicate = label => label.Id == id;
            }
            else
            {
                predicate = label => command.Ids.Contains(label.Id);
            }
        }

        if (command.Texts.Count > 0)
        {
            if (command.Texts.Count == 1)
            {
                var text = command.Texts[0];

                if (predicate == null)
                {
                    predicate = label => label.Text == text;
                }
                else
                {
                    var existingPredicate = predicate;

                    predicate = label => existingPredicate(label) && label.Text == text;
                }
            }
            else
            {
                if (predicate == null)
                {
                    predicate = label => command.Texts.Contains(label.Text);
                }
                else
                {
                    var existingPredicate = predicate;

                    predicate = label => existingPredicate(label) && command.Texts.Contains(label.Text);
                }
            }
        }

        return predicate;
    }
}