using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingBotDesktopClient
{
    public partial class StartupForm
    {

        private List<Func<Task>> startupFunctions = new List<Func<Task>>();

        public async void RunStartupHandler()
        {

        }
    }
}