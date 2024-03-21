using Syncfusion.Maui.Carousel;
using Syncfusion.Maui.Core.Carousel;

    namespace Carousel {
        public partial class MainPage : ContentPage {
            public MainPage() {
                InitializeComponent();
                sfCarousel.BindingContext = new CarouselViewModel();
            }
            public class CarouselViewModel {
                public CarouselViewModel() {
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
            public class CarouselModel {
                public List<Person> Data { get; set; }

                public CarouselModel() {
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
