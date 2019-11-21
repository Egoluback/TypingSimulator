using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypingSimulator
{
    class GenerateText
    {
        List<string> beginSentence = new List<string> { "Товарищи!", "С другой стороны, ", "Равным образом, ", "Не следует, однако, забывать, что ", "Таким образом, ", "Повседневная практика показывает, что ", "Значимость этих проблем настолько очевидна, что ", "Разнообразный и богатый опыт показывает, что ", "Задача организации, в особенности же ", "Идейные соображения высшего порядка, а также ", " В таком случае, " };
        List<string> con1 = new List<string> { "реализация намеченных планов ", "рамки и место обучения кадров ", "постоянный количественный рост и сфера нашей активности ", "сложившаяся структура организации ", "новая модель организационной деятельности ", "дальнейшее развитие различных форм деятельности ", "постоянное информационно-пропагандистское обеспечение нашей деятельности ", "укрепления и развития структуры ", "консультация с широким активом ", "начало повседневной работы по формированию позиции " };
        List<string> con2 = new List<string> { "играет важную роль в формировании ", "требуют от нас анализа ", "требуют определения и уточнения ", "способствуют подготовке и реализации ", "обеспечивает широкому кругу специалистов участие в формировании ", "позволяет выполнить важные задания по разработке ", "в значительной степени обуславливает создание ", "позволяет оценить значение ", "представляет собой интересный эксперимент проверки ", "влечет за собой процесс внедрения и модернизации " };
        List<string> con3 = new List<string> { "существующих финансовых и административных условий ", "дальнейших направлений развития ", "системы массового участия ", "позиций, занимаемых участниками в отношении поставленных задач ", "новых предложений ", "направлений прогрессивного развития ", "системы обучения кадров, соответствующей насущным потребностям ", "соответствующий условий активизации ", "модели развития ", "форм воздействия " };


        private int countSentences;

        private string prevSentence;

        public GenerateText(int _countSentences) {
            countSentences = _countSentences;
        }

        public string Generate() {
            Random random = new Random();

            string sentence = "";

            for (var i = 0; i < countSentences; i++)
            {
                string beginSent = beginSentence[random.Next(1, beginSentence.Count)];

                while (beginSent == prevSentence)
                {
                    beginSent = beginSentence[random.Next(1, beginSentence.Count)];
                }

                sentence += beginSent;
                prevSentence = beginSent;
                sentence += con1[random.Next(1, con1.Count)];
                sentence += con2[random.Next(1, con2.Count)];
                sentence += con3[random.Next(1, con3.Count)];
                sentence = sentence.Trim();
                sentence += ".";
            }

            return sentence;
        }
    }
}
