use kuva::prelude::*;

fn main() {
    let data = vec![
        ("A", 28.0),
        ("B", 55.0),
        ("C", 43.0),
        ("D", 91.0),
        ("E", 81.0),
        ("F", 53.0),
        ("G", 19.0),
        ("H", 87.0),
        ("I", 52.0),
    ];

    let plot = BarPlot::new().with_bars(data);

    let plots = vec![plot.into()];
    let layout = Layout::auto_from_plots(&plots)
        .with_x_label("a")
        .with_y_label("b");

    let png = render_to_png(plots, layout, 1.0).unwrap();
    std::fs::write("kuva-bar-chart.png", png).unwrap();
}
