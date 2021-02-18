using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;
using System.Drawing;
using System.Drawing.Imaging;
using ScottPlot;

namespace dotnet_scottplot
{
  public class Datum
  {
    [JsonPropertyName("a")]
    public string X { get; set; }
    [JsonPropertyName("b")]
    public double Y { get; set; }
  }

  class Program
  {
    static void Main(string[] args)
    {
      string jsonString = File.ReadAllText("data.json");
      // Console.WriteLine(jsonString.GetType());

      List<Datum> dataset = JsonSerializer.Deserialize<List<Datum>>(jsonString);
      // dataset.ForEach(item => Console.WriteLine($"{item.X}, {item.Y}"));

      string[] labels = dataset.Select(datum => datum.X).ToArray();
      double[] ys = dataset.Select(datum => datum.Y).ToArray();
      double[] xs = DataGen.Consecutive(labels.Length);
      // Array.ForEach(xs, Console.WriteLine);

      int width = 400;
      int height = 300;

      ScottPlot.Plot plt = new ScottPlot.Plot(width, height);
      plt.PlotBar(xs, ys, showValues: false);

      plt.XLabel("a");
      plt.XTicks(xs, labels);
      plt.YLabel("b");

      // More info: https://github.com/ScottPlot/ScottPlot/blob/4.0-stable/src/ScottPlot/Plot/Plot.cs.
      plt.SaveFig("scottplot-bar-chart.png");
    }
  }
}
