using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PropertyPrac
{
    class Box
    {

        public int width;
        public int height;

        public Box(int width, int height)
        {
            this.width = IsPositive(width);
            this.height = IsPositive(height);
            if(width>0&& height > 0)
            {
                this.width = width;
                this.height = height;
            }
            else
            {
                this.width = 1;
                this.height = 1;
                Console.WriteLine("매개변수는 양수여야 합니다");
                Console.WriteLine("width=1, height=1 객체가 생성됩니다");

            }
        }
        public int Area()
        {
            return this.width + this.height;
        }
        public int GetWidth()
        {
            return this.width;
        }
        public int GetHeight()
        {
            return this.height;
        }
        public void setWidth(int width)
        {
            if (width > 0)
            {
                this.width = width;
            }
            else
            {
                this.width = WIDTH_DEFAULT;
                Console.WriteLine("매개변수는 양수여야 합니다");
                Console.WriteLine("height=",SIZE_DEFAULT, "로 수정합니다");
            }
           
        }
        public void SetHeight(int height)
        {
            this.height = IsPositive(height);
            if (height > 0)
            {
                this.height = height;
            }
            else
            {
                this.width = WIDTH_DEFAULT;
                Console.WriteLine("매개변수는 양수여야 합니다");
                Console.WriteLine("height=", SIZE_DEFAULT, "로 수정합니다");
            }

        }
        private int IsPositive(int value)
        {
            if (height > 0)
            {
                return value;
            }
            else
            {
              
                Console.WriteLine("매개변수는 양수여야 합니다");
                Console.WriteLine("기본값인",SIZE_DEFAULT,"로 수정합니다");
                return SIZE_DEFAULT;
            }

        }

    }
}
