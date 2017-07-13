using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CocktailInspiration
{

    public class MainPageMasterDetailMenuItem
    {
        public MainPageMasterDetailMenuItem()
        {
            //TargetType = typeof(MainPageMasterDetailDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}