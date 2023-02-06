﻿using Microsoft.Diagnostics.Runtime.Utilities;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Jpeg;
using System.IO;
using System.Runtime.CompilerServices;


namespace KoderJPEG
{   
    public static class BmpToJpeg
    {
        public static void Convert(string[] inputFile, int quality) {
            Configuration.Default.ImageFormatsManager.SetEncoder(JpegFormat.Instance, new JpegEncoder()
            {
                Quality = quality
            }); ;
            
            Task[] tasks = new Task[inputFile.Length];
            for (int i = 0; i < inputFile.Length; i++)
            {
                string input = inputFile[i];
                if(!input.EndsWith(".bmp")) {
                    throw new Exception($"Input file not found:{input}");
                }
                tasks[i] = Task.Run(() => Encode(input,quality));
            }
            Task.WaitAll(tasks);

        }
        [MethodImpl(MethodImplOptions.AggressiveOptimization)]

        private static Task Encode(string inputFile, int quality)
        {
            using (var img = Image.Load(inputFile)) {
                img.SaveAsJpeg(Path.Combine("G:\\90", Path.GetFileNameWithoutExtension(inputFile) + quality+ ".jpg"));
            }
               
            return Task.CompletedTask;
        }

    }
}
