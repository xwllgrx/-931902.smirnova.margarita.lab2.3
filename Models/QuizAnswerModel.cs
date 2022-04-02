using Web2_lab3.Utils;

namespace Web2_lab3.Models {
    public class QuizAnswerModel {
        [LessThanOrNull(101, ErrorMessage = " Здесь не может быть такого большого числа. ")]
        public int? Answer { get; set; }
    }
}
