using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterLIO
{
    class AreaHelper
    {
        static Dictionary<KeyboardArea,char[]> areaSymbols = new Dictionary<KeyboardArea,char[]>();
        
        static AreaHelper()
        {
            areaSymbols.Add(KeyboardArea.ONE, new char[] { ' ' });
            areaSymbols.Add(KeyboardArea.TWO, new char[] { '1','2','й','ф','я' });
            areaSymbols.Add(KeyboardArea.THREE, new char[] { '3', 'ц', 'ы', 'ч' });
            areaSymbols.Add(KeyboardArea.FOUR, new char[] { '4', 'у', 'в', 'с' });
            areaSymbols.Add(KeyboardArea.FIVE, new char[] { '5', 'к', 'а', 'м', '6', 'е', 'п', 'и' });
            areaSymbols.Add(KeyboardArea.SIX, new char[] { '7', 'н', 'р', 'т', 'г', 'о', 'ь' });
            areaSymbols.Add(KeyboardArea.SEVEN, new char[] { '8', 'ш', 'л', 'б' });
            areaSymbols.Add(KeyboardArea.EIGHT, new char[] { '9', 'щ', 'д', 'ю' });
            areaSymbols.Add(KeyboardArea.NINE, new char[] { '0', 'з', 'х', 'ъ', 'ж', 'э'});
        }

        public static char[] getAreaSymbols(KeyboardArea area)
        {
            return areaSymbols[area];
        }

    }
}
