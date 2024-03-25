using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab_1
{
    public abstract class time
    {
        public CultureInfo myCIintl;

        public abstract string ShowTime();

        public time(CultureInfo myCIintl)
        {
            this.myCIintl = myCIintl;
        }
    }

    public class TimeEuro : time
    {
        public TimeEuro() : base(new CultureInfo("es-ES", false)) { }

        public override string ShowTime()
        {
            return DateTime.Now.ToString(myCIintl);
        }
    }

    public class TimeUS : time
    {
        public TimeUS() : base(new CultureInfo("en-US", false)) { }

        public override string ShowTime()
        {
            return DateTime.Now.ToString(myCIintl);
        }
    }

    public abstract class Decorator : time
    {
        private time _time;

        public Decorator(time time) : base(time.myCIintl)
        {
            _time = time;
        }

        public override string ShowTime()
        {
            return _time.ShowTime();
        }
    }

    public class TimeEuDecorator : Decorator
    {
        public TimeEuDecorator(TimeEuro timeEuro) : base(timeEuro) { }

        public override string ShowTime()
        {
            StringBuilder sb = new StringBuilder(base.ShowTime());
            sb.Append("     A    M   O   G   U   S");
            return sb.ToString();
        }
    }

    public class TimeUSDecorator : Decorator
    {
        public TimeUSDecorator(TimeUS timeUS) : base(timeUS) { }

        public override string ShowTime()
        {
            StringBuilder sb = new StringBuilder(base.ShowTime());
            sb.Append("     Hello, World !!!");
            return sb.ToString();
        }
    }
}

