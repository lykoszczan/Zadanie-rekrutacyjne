using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Zadanie_rekrutacyjne.Commands
{
    public class MyApplicationCommands
    {
        public static RoutedUICommand ConvetTo
                            = new RoutedUICommand("Converting to new txt file",
                                                  "ConvetTo",
                                                  typeof(MyApplicationCommands));
    }
}
