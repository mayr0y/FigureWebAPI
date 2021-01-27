using System;
using System.ComponentModel.DataAnnotations;

namespace FigureWebAPI.Models {
    public class CreateFigure {
        public long Id { get; set; }
        [Required(ErrorMessage = "Укажите имя фигуры")]
        public string Name { get; set; }
        [Range(1, 100, ErrorMessage = "Длина стороны должна быть положительная")]
        public int FirstSide { get; set; }
        [Range(1, 100, ErrorMessage = "Длина стороны должна быть положительная")]
        public int SecondSide { get; set; }
        [Range(1, 100, ErrorMessage = "Длина стороны должна быть положительная")]
        public int ThirdSide { get; set; }
        public int FigureArea { get; set; }

        public CreateFigure(int firstSide, int secondSide, int thirdSide) {
            FirstSide = (firstSide);
            SecondSide = (secondSide);
            ThirdSide = (thirdSide);

            var halfPerimetr = (firstSide + secondSide + thirdSide) / 2;
            var area = Math.Sqrt(halfPerimetr * (halfPerimetr - firstSide) *
                                                (halfPerimetr - secondSide) *
                                                (halfPerimetr - thirdSide));
            FigureArea = Convert.ToInt32(area);
        }   
    }
}
