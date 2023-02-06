using KoderJPEG;

//var summary = BenchmarkRunner.Run<Benchmarks.BmpToJpegBenchmarks>();

string[] strings = { "BaboonRGB.bmp", "img_2448x2448_3x8bit_SRC_RGB_chairsBMP.bmp", "img_8192x4320_3x16bit_RGB_color_rainbow_gradientBMP.bmp" };
int quality = 90;
BmpToJpeg.Convert(strings, quality);







