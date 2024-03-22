# How-to-load-a-chart-control-into-a-.NET-MAUI-Carousel

This section explains how to load Chart control into .NET MAUI Carousel.

Define ItemTemplate for the Chart control in XAML.
Add ItemTemplate as Chart control before creating the Carousel control.

**XAML**
```
 <ContentPage.Resources>
      <ResourceDictionary>
          <DataTemplate x:Key="itemTemplate">             
              <chart:SfCartesianChart>
                  <chart:SfCartesianChart.XAxes>
                      <chart:CategoryAxis>
                          <chart:CategoryAxis.Title>
                              <chart:ChartAxisTitle Text="Name"></chart:ChartAxisTitle>
                          </chart:CategoryAxis.Title>
                      </chart:CategoryAxis>
                  </chart:SfCartesianChart.XAxes>
                  <chart:SfCartesianChart.YAxes>
                      <chart:NumericalAxis>
                          <chart:NumericalAxis.Title>
                              <chart:ChartAxisTitle Text="Height (in cm)"></chart:ChartAxisTitle>
                          </chart:NumericalAxis.Title>
                      </chart:NumericalAxis>
                  </chart:SfCartesianChart.YAxes>                   
                      <chart:ColumnSeries ItemsSource="{Binding Data}" XBindingPath="Name" YBindingPath="Height">
                      </chart:ColumnSeries>                   
              </chart:SfCartesianChart>
          </DataTemplate>
      </ResourceDictionary>
  </ContentPage.Resources> 

   <carousel:SfCarousel x:Name="sfCarousel" 
                          ItemsSource="{Binding ImageCollection}"  
                          ItemTemplate="{StaticResource itemTemplate}"/>

```

**C#**

```
namespace Carousel 
   {
    public partial class MainPage : ContentPage {
        public MainPage() 
        {
            InitializeComponent();
            sfCarousel.BindingContext = new CarouselViewModel();
        }
        public class CarouselViewModel 
        {
            public CarouselViewModel() 
            {
                ImageCollection.Add(new CarouselModel());
                ImageCollection.Add(new CarouselModel());
                ImageCollection.Add(new CarouselModel());
                ImageCollection.Add(new CarouselModel());
                ImageCollection.Add(new CarouselModel());
            }
            private List<CarouselModel> imageCollection = new List<CarouselModel>();
            public List<CarouselModel> ImageCollection {
                get { return imageCollection; }
                set { imageCollection = value; }
            }
        }
        public class CarouselModel 
        {
            public List<Person> Data { get; set; }

            public CarouselModel(){
                Data = new List<Person>(){
                new Person { Name = "David", Height = 180 },
                new Person { Name = "Michael", Height = 170 },
                new Person { Name = "Steve", Height = 160 },
                new Person { Name = "Joel", Height = 182 }
                };
             }
        }
        public class Person {
            public string Name { get; set; }
            public double Height { get; set; }
        }
    }
}
```