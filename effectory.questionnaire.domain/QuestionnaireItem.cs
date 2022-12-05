using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace effectory.questionnaire.domain
{
    public class QuestionnaireItem
    {
        public int? SubjectId { get; set; }
        public int? QuestionId { get; set; }
        public int? AnswerId { get; set; }
        public int OrderNumber { get; set; }
        public Dictionary<string, string> Texts { get; set; }
        public ItemType ItemType { get; set; }
        public List<QuestionnaireItem> QuestionnaireItems { get; set; }

        public bool ByItemType(ItemType type)
        {
            var byType = this.ItemType == type;
            if (!byType & QuestionnaireItems != null)
            {
                return QuestionnaireItems.Any(child => child.ByItemType(type));
            }
            return byType;
        }

        public bool ByQuestionId()
        {
            var byId = this.QuestionId != null;
            if (QuestionnaireItems != null)
            {
                return QuestionnaireItems.Any(child => child.ByQuestionId());
            }
            return byId;
        }
    }
}
