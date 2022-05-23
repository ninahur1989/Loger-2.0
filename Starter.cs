using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    internal class Starter
    {
        public void Run()
        {
            Random random = new Random();
            Actions actions = new Actions();

            for (int i = 0; i < 10; i++)
            {
                int r = random.Next(0, 3);
                Result result = new Result();

                if (r == 0)
                {
                    result = actions.Info();
                }
                else if (r == 1)
                {
                    result = actions.Warning();
                }
                else
                {
                    result = actions.Error();
                }

                Logger.Instance.Addlog(result);
            }

            Logger.Instance.Show();
        }
    }
}
