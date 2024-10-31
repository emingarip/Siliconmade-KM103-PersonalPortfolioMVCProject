using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums;

public enum Educations
{
    [Description("İlkokul seviyesi")]

    Ilkokul = 1,
    [Description("Lise seviyesi")]

    Lise = 2,
    [Description("Üniversite seviyesi")]

    Universite = 3,
    [Description("Yüksek seviyesi")]

    YuksekLisans = 4,
    [Description("Doktora seviyesi")]
    Doktora = 5


}
