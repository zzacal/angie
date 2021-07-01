using System;
using System.Collections.Generic;

namespace angie.Pages
{
    public static class MediaHelpers
    {
        public static Media GetMedia() 
        {
            var media = new Media();
            media.Images = new List<string> {
                "16553B27-D9E8-467D-8B1A-3D414084759E.jpeg",
                "640819A6-8DFA-4B81-B26A-853329BE32EA.jpeg",
                "6E5BEAEE-4DEC-4EFE-8844-EA74FEED3196.jpeg",
                "87672793-1D81-4C97-8B8F-8F19A336CF89.jpeg",
                "8A412E9B-DC7B-43ED-937F-06B1F8CD375C.jpeg",
                "9743B17F-E5AF-4949-877A-1856E883619B.jpeg",
                "BF8B7B8D-B377-487A-BDEB-F7EAF3105CD1.jpeg",
                "D1C01CB0-8D89-483C-871A-36AC3B690586.jpeg"
            };
            return media;
        }
    }
    public class Media
    {
        public List<string> Images { get; set; }
    }
}