using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace TheBlogProject.Enums
{
    public enum ModerationType
    {   
        [Description("Political Propaganda")]
        Political,
        [Description("Inappropriate Language")]
        Language,
        [Description("Drug refferences")]
        Drugs,
        [Description("Threatening speech")]
        Threatening,
        [Description("Sexual content")]
        UnwantedComments,
        [Description("Hate Speech")]
        HateSpeech,
        [Description("Targeted Shaming")]
        Shaming
    }
}
