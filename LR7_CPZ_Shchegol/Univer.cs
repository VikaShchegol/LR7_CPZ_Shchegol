using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7_CPZ_Shchegol
{
        public class Univer
        {
            public string Name { get; set; }
            public int FoundationYear { get; set; }
            public int NumberOfGraduates { get; set; }
            public bool HasDoctoralPrograms { get; set; }
            public bool HasSportsComplex { get; set; }
            public bool HasPool { get; set; }
            public bool HasTeachers { get; set; }

            public Univer() { }

            public Univer(string name, int foundationYear, int numberOfGraduates, bool hasDoctoralPrograms, bool hasSportsComplex, bool hasPool, bool hasTeachers)
            {
                Name = name;
                FoundationYear = foundationYear;
                NumberOfGraduates = numberOfGraduates;
                HasDoctoralPrograms = hasDoctoralPrograms;
                HasSportsComplex = hasSportsComplex;
                HasPool = hasPool;
                HasTeachers = hasTeachers;
            }

            public static int CalculateTotalGraduates(Univer[] universities)
            {
                return universities.Sum(u => u.NumberOfGraduates);
            }
        }
    }
