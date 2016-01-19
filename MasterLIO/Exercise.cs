using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterLIO
{
    class Exercise
    {
        public int id { get; set; }
        public String name { get; set; }
        public int length { get; set; }
        public int maxErrors { get; set; }
        public int maxTime { get; set; }
        public List<KeyboardArea> areas { get; set; }
        public String text { get; set; }
        public int level { get; set; }

        public Exercise()//sample
        {
            this.name = "Sample";
            this.text = "aaa";

            List<KeyboardArea> sampleAreas = new List<KeyboardArea>();
            sampleAreas.Add(KeyboardArea.NINE);
            sampleAreas.Add(KeyboardArea.ONE);

            this.areas = sampleAreas;

            this.maxErrors = 4;
            this.level = areas.Capacity;
            this.length = this.text.Length;
        }

        public Exercise(String name, String text, List<KeyboardArea> areas, int maxErrors)
        {
            this.name = name;
            this.text = text;
            this.areas = areas;
            this.maxErrors = maxErrors;
            this.level = areas.Capacity; // уровень = количеству заюзаных зон
            this.length = text.Length;
        }

        public Exercise(String name, String text, List<KeyboardArea> areas, int maxErrors, int maxTime)
        {
            this.name = name;
            this.text = text;
            this.areas = areas;
            this.maxErrors = maxErrors;
            this.level = areas.Capacity;
            this.maxTime = maxTime;
            this.length = text.Length;
        }

        public Exercise(int id, String name, String text, List<KeyboardArea> areas, int maxErrors)
        {
            this.id = id;
            this.name = name;
            this.text = text;
            this.areas = areas;
            this.maxErrors = maxErrors;
            this.level = areas.Capacity; // уровень = количеству заюзаных зон
            this.length = text.Length;
        }

        public Exercise(String name, String text, List<KeyboardArea> areas, int maxErrors, int maxTime, int level)
        {
            this.name = name;
            this.text = text;
            this.areas = areas;
            this.maxErrors = maxErrors;
            this.level = areas.Capacity; // уровень = количеству заюзаных зон
            this.length = text.Length;
            this.maxTime = maxTime;
            this.level = level;
        }


        public Exercise(int id, String name, String text, List<KeyboardArea> areas, int maxErrors, int maxTime)
        {
            this.id = id;
            this.name = name;
            this.text = text;
            this.areas = areas;
            this.maxErrors = maxErrors;
            this.level = areas.Capacity; // уровень = количеству заюзаных зон
            this.maxTime = maxTime;
            this.length = text.Length;
        }

        public Exercise(int id, string name, string text, List<KeyboardArea> listAreas, int maxErrors, int maxTime, int level)
        {
            this.id = id;
            this.name = name;
            this.text = text;
            this.areas = areas;
            this.maxErrors = maxErrors;
            this.level = level; // уровень = количеству заюзаных зон
            this.maxTime = maxTime;
            this.length = text.Length;
        }

        public static String getAreasAsString(List<KeyboardArea> areas)
        {
            String stringAreas = "";
            foreach (KeyboardArea area in areas)
            {
                stringAreas += area.ToString() + " ";
            }
            return stringAreas;
        }

        public static String getAreasAsStringNumber(List<KeyboardArea> areas)
        {
            String stringAreas = "";
            foreach (KeyboardArea area in areas)
            {
                stringAreas += area.ToString() + " ";
            }
            return stringAreas;
        }

        public List<Char> getTextsAsArrayChar()
        {
            List<Char> arrayChar = new List<Char>();
            for (int i = 0; i < this.text.Length; i++)
            {
                arrayChar.Add(this.text[i]);
            }
            return arrayChar;
        }

        public static String getAreasAsNums(List<KeyboardArea> areas)
        {
            String nums = "";
            if (areas.Contains(KeyboardArea.ONE)) nums += "1 ";
            if (areas.Contains(KeyboardArea.TWO)) nums += "2 ";
            if (areas.Contains(KeyboardArea.THREE)) nums += "3 ";
            if (areas.Contains(KeyboardArea.FOUR)) nums += "4 ";
            if (areas.Contains(KeyboardArea.FIVE)) nums += "5 ";
            if (areas.Contains(KeyboardArea.SIX)) nums += "6 ";
            if (areas.Contains(KeyboardArea.SEVEN)) nums += "7 ";
            if (areas.Contains(KeyboardArea.EIGHT)) nums += "8 ";
            if (areas.Contains(KeyboardArea.NINE)) nums += "9 ";
            return nums;
        }

        public static String getAreasAsNums(String areas)
        {
            String nums = "";
            if (areas.Contains("1")) nums += KeyboardArea.ONE.ToString() + " ";
            if (areas.Contains("2")) nums += KeyboardArea.TWO.ToString() + " ";
            if (areas.Contains("3")) nums += KeyboardArea.THREE.ToString() + " ";
            if (areas.Contains("4")) nums += KeyboardArea.FOUR.ToString() + " ";
            if (areas.Contains("5")) nums += KeyboardArea.FIVE.ToString() + " ";
            if (areas.Contains("6")) nums += KeyboardArea.SIX.ToString() + " ";
            if (areas.Contains("7")) nums += KeyboardArea.SEVEN.ToString() + " ";
            if (areas.Contains("8")) nums += KeyboardArea.EIGHT.ToString() + " ";
            if (areas.Contains("9")) nums += KeyboardArea.NINE.ToString() + " ";
            return nums;
        }

        public static List<KeyboardArea> getAreasList(String areas)
        {
            List<KeyboardArea> enumAreas = new List<KeyboardArea>();

            string[] areasList = areas.Split(new Char[] { ' ' });

            foreach (string area in areasList)
            {
                if (System.Enum.IsDefined(typeof(KeyboardArea), area))
                {
                    KeyboardArea enumArea = (KeyboardArea)Enum.Parse(typeof(KeyboardArea), area);
                    enumAreas.Add(enumArea);
                }
            }

            return enumAreas;
        }

    }

    public enum KeyboardArea { ONE,TWO,THREE,FOUR,FIVE,SIX,SEVEN,EIGHT,NINE }//девять зон клавиатуры
    

}
