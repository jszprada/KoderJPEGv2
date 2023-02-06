using System.Diagnostics;
using BenchmarkDotNet.Attributes;

namespace Benchmarks;

[MemoryDiagnoser]
[ThreadingDiagnoser]
[MinColumn, MaxColumn, MeanColumn, MedianColumn]
[InProcessAttribute]


public class BmpToJpegBenchmarks
{   
    public string[] strings = {@"F:\BIBlioteka_zdjęc\BMP_100\Baboon.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\BaboonRGB.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\barbara.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\barbara_gray.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\boats.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\boats24.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_1x16bit_SRC_GRAY_almondsBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_1x16bit_SRC_GRAY_applesBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_1x16bit_SRC_GRAY_baloonsBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_1x16bit_SRC_GRAY_bananasBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_1x16bit_SRC_GRAY_billiard_balls_aBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_1x16bit_SRC_GRAY_billiard_balls_bBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_1x16bit_SRC_GRAY_buildingBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_1x16bit_SRC_GRAY_cards_aBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_1x16bit_SRC_GRAY_cards_bBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_1x16bit_SRC_GRAY_carrotsBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_1x16bit_SRC_GRAY_chairsBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_1x16bit_SRC_GRAY_clipsBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_1x16bit_SRC_GRAY_coinsBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_1x16bit_SRC_GRAY_cushionsBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_1x16bit_SRC_GRAY_ducksBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_1x16bit_SRC_GRAY_fenceBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_1x16bit_SRC_GRAY_flowersBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_1x16bit_SRC_GRAY_garden_tableBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_1x16bit_SRC_GRAY_guitar_bridgeBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_1x16bit_SRC_GRAY_guitar_fretBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_1x16bit_SRC_GRAY_guitar_headBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_1x16bit_SRC_GRAY_keyboard_aBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_1x16bit_SRC_GRAY_keyboard_bBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_1x16bit_SRC_GRAY_lionBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_1x16bit_SRC_GRAY_multimeterBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_1x16bit_SRC_GRAY_pencils_aBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_1x16bit_SRC_GRAY_pencils_bBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_1x16bit_SRC_GRAY_pillarBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_1x16bit_SRC_GRAY_plasticBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_1x16bit_SRC_GRAY_roofBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_1x16bit_SRC_GRAY_scarfBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_1x16bit_SRC_GRAY_screwsBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_1x16bit_SRC_GRAY_snailsBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_1x16bit_SRC_GRAY_socksBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_1x16bit_SRC_GRAY_sweetsBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_1x16bit_SRC_GRAY_tomatoes_aBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_1x16bit_SRC_GRAY_tomatoes_bBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_1x16bit_SRC_GRAY_tools_aBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_1x16bit_SRC_GRAY_tools_bBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_1x16bit_SRC_GRAY_wood_gameBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_3x8bit_SRC_RGB_almondsBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_3x8bit_SRC_RGB_applesBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_3x8bit_SRC_RGB_baloonsBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_3x8bit_SRC_RGB_bananasBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_3x8bit_SRC_RGB_billiard_balls_aBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_3x8bit_SRC_RGB_billiard_balls_bBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_3x8bit_SRC_RGB_buildingBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_3x8bit_SRC_RGB_cards_aBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_3x8bit_SRC_RGB_cards_bBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_3x8bit_SRC_RGB_carrotsBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_3x8bit_SRC_RGB_chairsBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_3x8bit_SRC_RGB_clipsBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_3x8bit_SRC_RGB_coinsBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_3x8bit_SRC_RGB_cushionsBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_3x8bit_SRC_RGB_ducksBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_3x8bit_SRC_RGB_fenceBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_3x8bit_SRC_RGB_flowersBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_3x8bit_SRC_RGB_garden_tableBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_3x8bit_SRC_RGB_guitar_bridgeBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_3x8bit_SRC_RGB_guitar_fretBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_3x8bit_SRC_RGB_guitar_headBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_3x8bit_SRC_RGB_keyboard_aBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_3x8bit_SRC_RGB_keyboard_bBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_3x8bit_SRC_RGB_lionBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_3x8bit_SRC_RGB_multimeterBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_3x8bit_SRC_RGB_pencils_aBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_3x8bit_SRC_RGB_pencils_bBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_3x8bit_SRC_RGB_pillarBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_3x8bit_SRC_RGB_plasticBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_3x8bit_SRC_RGB_roofBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_3x8bit_SRC_RGB_scarfBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_3x8bit_SRC_RGB_screwsBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_3x8bit_SRC_RGB_snailsBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_3x8bit_SRC_RGB_socksBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_3x8bit_SRC_RGB_sweetsBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_3x8bit_SRC_RGB_tomatoes_aBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_3x8bit_SRC_RGB_tomatoes_bBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_3x8bit_SRC_RGB_tools_aBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_3x8bit_SRC_RGB_tools_bBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_2448x2448_3x8bit_SRC_RGB_wood_gameBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_4096x2560_3x16bit_RGB_bars_horizontal_square_0008_1xhalfPIBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_4096x2560_3x16bit_RGB_grid_circles_progressive_aBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_4096x2560_3x16bit_RGB_grid_circles_progressive_bBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_4096x2560_3x16bit_RGB_grid_rectangle_0128x0080_0BMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_4096x2560_3x16bit_RGB_grid_rectangle_0128x0080_1BMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_8192x4320_3x16bit_RGB_color_bars_CMYKWRGBBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_8192x4320_3x16bit_RGB_color_bars_CMYKWRGB_100IREBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_8192x4320_3x16bit_RGB_color_bars_CMYKWRGB_75IREBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_8192x4320_3x16bit_RGB_color_bars_CMYKWRGB_gradientBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_8192x4320_3x16bit_RGB_color_rainbowBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_8192x4320_3x16bit_RGB_color_rainbow_gradientBMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\img_8192x4320_3x16bit_RGB_color_SMPTE_RP_219_2002BMP.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\lena24.bmp",
@"F:\BIBlioteka_zdjęc\BMP_100\lena_gray.bmp"};
    
    [Params(100,80,60,40,20)]
    public int Quality { get; set; }
    
    [Benchmark]
    public void ConvertWithLowestPriority()
    {
      Thread.CurrentThread.Priority = ThreadPriority.Lowest;
      ConvertAndMeasurePerformance();
    }
    [Benchmark]
    public void ConvertWithBelowNormalPriority()
    {
        Thread.CurrentThread.Priority = ThreadPriority.BelowNormal;
        ConvertAndMeasurePerformance();
    }
    [Benchmark]
    public void ConvertWithNormalPriority()
    {
        Thread.CurrentThread.Priority = ThreadPriority.Normal;
        ConvertAndMeasurePerformance();
    }
    [Benchmark]
    public void ConvertWithAboveNormalPriority()
    {
       Thread.CurrentThread.Priority = ThreadPriority.AboveNormal;
       ConvertAndMeasurePerformance();
    }
    [Benchmark]
   public void ConvertWithHighestPriority()
    {
       Thread.CurrentThread.Priority = ThreadPriority.Highest;
       ConvertAndMeasurePerformance();
    }/*
    [Benchmark]
    public void Test()
    {
        ConvertAndMeasurePerformance();
    }*/
    public void ConvertAndMeasurePerformance()
    {
        var stopwatch = Stopwatch.StartNew();

       //BmpToJpeg.Convert(strings, Quality);

        stopwatch.Stop();
        Console.WriteLine($"Conversion took {stopwatch.ElapsedMilliseconds} milliseconds");
    }

}

