using System;

namespace BL_8_Struct_Enum_Tuple_Generic
{
    partial class Practice
    {
        public static Random random = new Random();


        /// <summary>
        /// BL8-P1/3. Cоздать структуру 2DRectangle, которая будет содержать ширину, высоту и координату.
        /// </summary>

        public struct Rectangle
        {
            public int x;
            public int y;
            public int width;
            public int height;

            public Rectangle(int x, int y, int width, int height)
            {
                this.x = x;
                this.y = y;
                this.width = width;
                this.height = height;
            }
        }

        public static void Lb8_P1_3()
        {
            Rectangle rect = new Rectangle(5, 7, 12, 15);
        }


        /// <summary>
        /// BL8-P2/3. Cоздать случайный массив квадратов с количеством элементов 100. 
        /// Используйте класс Random(10), чтоб установить значения сторон. 
        /// </summary>
        public static void Lb8_P2_3()
        {
            Rectangle[] rectangle = new Rectangle[100];

            for (int i = 0; i < rectangle.Length; i++)
            {
                rectangle[i].width = random.Next(1, 10);
                rectangle[i].height = rectangle[i].width;
            }

            var dublicates = 0;

            for (var i = 0; i < rectangle.Length; i++)
            {
                for (var j = i + 1; j < rectangle.Length - 1; j++)
                {
                    if (rectangle[i].width == rectangle[j].width)
                    {
                        dublicates++;
                    }
                }
            }

            Console.WriteLine($"Number of duplicates: {dublicates}");
        }

        /// <summary>
        /// BL8-P3/3.Anonymous. Создать метод GetSongData, 
        /// который принимает обьекта типа Song и возвращает анонимный тип, 
        /// который содержит Title, Minutes, Seconds и AlbumYear. 
        /// </summary>
        public static void Lb8_P3_3_Anonymous()
        {
        }
    }
}
