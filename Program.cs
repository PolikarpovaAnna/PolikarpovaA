using System;



namespace job2

{
    internal class lab2
    {
        abstract class GeometryFigure :ICode
        {

            protected abstract double calcArea();

            protected abstract String ObjectToString();

            public abstract void Code();

        }
        
        class Rectangle : GeometryFigure

        {

            private double width, height;

            public Rectangle(double width, double height)

            {

                this.width = width;

                this.height = height;

            }

            public Rectangle()

            {

            }
            protected override double calcArea()

            {

                return width * height;

            }


            protected override String ObjectToString()

            {

                return $"Object:Rectangle\nWidth = {width}\nHeight = {height}\nArea = {calcArea()}\n";

            }

            public override void Code()

            {

                Console.Write(ObjectToString());

            }

        }

        class Square : Rectangle

        {

            private double mSide;

            public Square(double mSide)

            {

                this.mSide = mSide;

            }

            protected override double calcArea()

            {

                return Math.Pow(mSide, 2);

            }

            protected override String ObjectToString()

            {

                return $"Object:Square\nSide:{mSide}\nArea = {calcArea()}\n";

            }

            public override void Code()

            {

                Console.Write(ObjectToString());

            }

        }

        class Circle : GeometryFigure

        {

            private double mRadius;

            public Circle(double mRadius)

            {

                this.mRadius = mRadius;

            }

            protected override double calcArea()

            {

                return Math.PI * Math.Pow(mRadius, 2);

            }

            protected override String ObjectToString()

            {

                return $"Object: Circle\nRadius = {mRadius}\nArea = {calcArea()}\n";

            }

            public override void Code()

            {

                Console.Write(ObjectToString());

            }

        }

        public static void Main(string[] args)

        {

            Rectangle mRectangle = new Rectangle(10, 10);

            Square mSquare = new Square(10);

            Circle mCircle = new Circle(10);

            mRectangle.Code();

            mSquare.Code();

            mCircle.Code();

        }

    }

}