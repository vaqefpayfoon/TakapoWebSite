using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TakapoWebSite.Models;

namespace TakapoWebSite.Area.Fa.Controllers
{
    [Area("Fa")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IHttpContextAccessor _httpContextAccessor;
        public HomeController(ILogger<HomeController> logger,
            IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            _httpContextAccessor = httpContextAccessor;
            if (Request != null && Request.Cookies["lang"] == null)
            {
                SetCookie("lang", "Fa", 1);
            }

        }
        public IActionResult ChangeLanguage(string key, string value)
        {
            SetCookie(key, value, 5);
            //string cookieValueFromContext = _httpContextAccessor.HttpContext.Request.Cookies["lang"];
            //string cookieValueFromReq = Request.Cookies["lang"];
            // return View("Index");
            return RedirectToAction("Index", "Home",
                        new { Area = value });
        }
        private void SetCookie(string key, string value, int? expireTime)
        {
            Response.Cookies.Delete(key);
            CookieOptions option = new CookieOptions();

            if (expireTime.HasValue)
                option.Expires = DateTime.Now.AddHours(expireTime.Value);
            else
                option.Expires = DateTime.Now.AddHours(1);

            Response.Cookies.Append(key, value, option);
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Support()
        {
            return View();
        }
        public IActionResult Imaging(string name)
        {
            List<Product> lst;
            switch (name)
            {
                case "mammography3d":
                    {
                        Product product = new Product
                        {
                            Id = 1,
                            ImageTitle = "ماموگرافی دیجیتال دو بعدی و سه بعدی",
                            ImagePassage = "",
                            ImageUrl = @"/assets/img/Imaging/3Dimensions.jpg",
                            ImageAlt = "3Dimensions",
                            ProductDetails = new List<ProductDetail>()
                            {
                                new ProductDetail
                                {
                                    Id = 1,
                                    ProductId = 1,
                                    Passage = "اولین دستگاه مامو گرافی دیجیتال مورد تائید FDA امریکا"
                                },
                                new ProductDetail
                                {
                                    Id = 2,
                                    ProductId = 1,
                                    Passage = "امکان استفاده همزمان از دو تکنیک تصویربرداری دو بعدی و سه بعدی"
                                },
                                new ProductDetail
                                {
                                    Id = 3,
                                    ProductId = 1,
                                    Passage = " کیفیت باالتر تشخیص با آنالیز تصاویر )View Combo (3D+2D در مقایسه با تصاویر 2"
                                },
                                new ProductDetail
                                {
                                    Id = 4,
                                    ProductId = 1,
                                    Passage = "کاهش انجام بایوپسی های غیر ضروری"
                                },
                                new ProductDetail
                                {
                                    Id = 5,
                                    ProductId = 1,
                                    Passage = "تصویربرداری از بافت در زوایای مختلف و ارائه تصاویری با ضخامت1 میلیمتر پس از بازسازی سه بعدی"
                                },
                                new ProductDetail
                                {
                                    Id = 6,
                                    ProductId = 1,
                                    Passage = "امکان بازبینی بافت در لایه های مختلف تصویر"
                                }
                            },
                            CompleteInfo = new List<ProductDetail>()
                        };
                        lst = new List<Product>();
                        lst.Add(product);
                    }
                    break;
                case "mammography2d":
                    {
                        Product product = new Product
                        {
                            Id = 1,
                            ImageTitle = "مامو گرافی دیجیتال دوبعدی مدل",
                            ImagePassage = "Selenia Dimensions System  Avia 3000 Package",
                            ImageUrl = @"/assets/img/Imaging/2Dimensions.jpg",
                            ImageAlt = "3Dimensions",
                            ProductDetails = new List<ProductDetail>()
                            {
                                new ProductDetail
                                {
                                    Id = 1,
                                    ProductId = 1,
                                    Passage = "اولین دستگاه مامو گرافی دیجیتال مورد تائید FDA امریکا"
                                },
                                new ProductDetail
                                {
                                    Id = 2,
                                    ProductId = 1,
                                    Passage = "استفاده از دیتکتور دیجیتال Direct Digital RADIOLOGY -DDR  جهت تبدیل مستقیم اشعه ایکس به تصویر با اندازه پیکسل 70 mµ و دتکتور سایز 24X29 cm"
                                },
                                new ProductDetail
                                {
                                    Id = 3,
                                    ProductId = 1,
                                    Passage = "پدلهای هوشمند smart paddles جهت کنترل AEC و کالیماسیون اتو ماتیک و پوزیشن دهی صحیح بیمار"
                                },
                                new ProductDetail
                                {
                                    Id = 4,
                                    ProductId = 1,
                                    Passage = "استفاده از F.A.S.T Paddle    برای ایجاد فشار یکنواخت بروی بافت ، کاهش درد بیمار ، کاهش ارتیفکت حرکتی و در نتیجه کیفیت بالاتر تصاویر"
                                },
                                new ProductDetail
                                {
                                    Id = 5,
                                    ProductId = 1,
                                    Passage = "قابلیت چرخش بازوی دستگاه از 150° - تا 195° +"
                                },
                                new ProductDetail
                                {
                                    Id = 6,
                                    ProductId = 1,
                                    Passage = "تصویر برداری سریع با دوز بسیار کم و"
                                }
                            },
                            CompleteInfo = new List<ProductDetail>()
                            {
                                new ProductDetail
                                {
                                    Id = 7,
                                    ProductId = 1,
                                    Passage = "استفاده از تیوپ اشعه  ایکس از جنس تنگستن برای کاهش دوز دریافتی بیمار "
                                },
                                new ProductDetail
                                {
                                    Id = 8,
                                    ProductId = 1,
                                    Passage = "امکان اتصال به PACS  و سازگار با DICOM 3 "
                                },
                                new ProductDetail
                                {
                                    Id = 9,
                                    ProductId = 1,
                                    Passage = "قابلیت کاربردی با workstation  های مخصوص مامو گرافی "
                                },
                                new ProductDetail
                                {
                                    Id = 10,
                                    ProductId = 1,
                                    Passage = "جایگاه نخست سیستم های مامو گرافی دیجیتال کمپانی Hologic در دنیا طبق اعلام موسسه  KLAS  در 7 سال متوالی "
                                },
                                new ProductDetail
                                {
                                    Id = 11,
                                    ProductId = 1,
                                    Passage = "امکان  استفاده از سیستم بایوپسی بصورت نشسته یا خوابیده به پهلو "
                                }
                            }
                        };
                        lst = new List<Product>();
                        lst.Add(product);
                    }
                    break;
                case "horizon":
                    {
                        Product product = new Product
                        {
                            Id = 2,
                            ImageTitle = "دستگاه سنجش تراکم استخوان",
                            ImagePassage = "مدل های  Horizon ",
                            ImageUrl = @"/assets/img/Imaging/horizon.jpg",
                            ImageAlt = "horizon",
                            ProductDetails = new List<ProductDetail>()
                            {
                                new ProductDetail
                                {
                                    Id = 12,
                                    ProductId = 2,
                                    Passage = "سیستم های سنجش تراکم استخوان با تکنولوژی DXA به روش True-fan beam"
                                },
                                new ProductDetail
                                {
                                    Id = 13,
                                    ProductId = 2,
                                    Passage = "دارای تأییدیه FDA آمریکا"
                                },
                                new ProductDetail
                                {
                                    Id = 14,
                                    ProductId = 2,
                                    Passage = "استفاده از تیوب اشعه ایکس با ظرفیت بالا و سیستم خنک کننده روغن"
                                },
                                new ProductDetail
                                {
                                    Id = 15,
                                    ProductId = 2,
                                    Passage = "استفاده از 64 تا 216المنت دیتکتور(Multi Element Detector)"
                                },
                                new ProductDetail
                                {
                                    Id = 16,
                                    ProductId = 2,
                                    Passage = "سرعت بالای اسکن"
                                },
                                new ProductDetail
                                {
                                    Id = 6,
                                    ProductId = 1,
                                    Passage = "تصویر برداری سریع با دوز بسیار کم و"
                                },
                                new ProductDetail
                                {
                                    Id = 18,
                                    ProductId = 2,
                                    Passage = "مستقل بودن دقت دستگاه از وزن بیمار و سرعت اسکن"
                                }
                            },
                            CompleteInfo = new List<ProductDetail>()
                            {
                                new ProductDetail
                                {
                                    Id = 17,
                                    ProductId = 2,
                                    Passage = "سیستم کالیبراسیون اتوماتیک داخلی برای هر اسکن، به صورت پیکسل به پیکسل و بدون دخالت اپراتور"
                                },                                
                                new ProductDetail
                                {
                                    Id = 19,
                                    ProductId = 2,
                                    Passage = "قابلیت کاربردی با workstation  های مخصوص مامو گرافی "
                                },
                                new ProductDetail
                                {
                                    Id = 20,
                                    ProductId = 2,
                                    Passage = "صحت و دقت و پایداری نتایج در کوتاه مدت و بلند مدت"
                                },
                                new ProductDetail
                                {
                                    Id = 21,
                                    ProductId = 2,
                                    Passage = "پیشتاز ابداع نسل جدید تکنولوژی آنالیز شکستگی مهره ها و دفورمیتی ستون فقرات (IVA-HD) به صورت سینگل انرژی با دو برابر شدن رزولوشن نسبت به روش های قدیمی، دوز پایین و ارائه گزارش تجمیعی دو فاکتور BMD و IVA برای آنالیز ریسک استئوپروز"
                                },
                                new ProductDetail
                                {
                                    Id = 22,
                                    ProductId = 2,
                                    Passage = "امکان ارزیابی Fracture risk در 10 سال آینده بر اساس استاندارد WHO"
                                },
                                new ProductDetail
                                {
                                    Id = 23,
                                    ProductId = 2,
                                    Passage = "استفاده انحصاری از دستگاه های هالوژیک برای مطالعات مهم شامل تهیه دیتابیس مرجع NHANES BMD، مطالعات سن،سلامت، Body Composition و مطالعه BMD اطفال و نوزادان(NIH)"
                                },
                                new ProductDetail
                                {
                                    Id = 24,
                                    ProductId = 2,
                                    Passage = "استفاده از یک پلت فرم واحد برای ارزیابی شکستگی های مهره ای در هر دو جهتAP و Lateral، بررسی ریسک های قلبی عروقی و چاقی"
                                },
                                new ProductDetail
                                {
                                    Id = 25,
                                    ProductId = 2,
                                    Passage = "امکان انجام Supine lateral BMD برای حذف خطای پوزیشن دهی مجدد بیمار"
                                },
                                new ProductDetail
                                {
                                    Id = 26,
                                    ProductId = 2,
                                    Passage = "نرم افزار انحصاری هالوژیک برای مشاهده کلسیفیکاسیون آئورت شکمی و بررسی ریسک های قلبی عروقیAAC(Abdominal Aortic Calcification) با انجام تست IVA-HD، مورد تأیید FDA آمریکا"
                                },
                                new ProductDetail
                                {
                                    Id = 27,
                                    ProductId = 2,
                                    Passage = "بررسی ساختار استخوان هیپ (HAS) با استفاده از اطلاعات ساختار هندسی هیپ و اطلاعات بیومکانیکال توان استخوان فمور"
                                },
                                new ProductDetail
                                {
                                    Id = 28,
                                    ProductId = 2,
                                    Passage = "نرم افزار اختصاصی جدید برای بررسی BMD در اطفال با امکان افزایش سرعت اسکن،کاهش دوز دریافتی کودک و انجام آنالیز بر اساس دیتابیس انحصاری اطفال"
                                },
                                new ProductDetail
                                {
                                    Id = 29,
                                    ProductId = 2,
                                    Passage = "گزارش دهی دقیق بر اساس استاندارد های جهانی ISCD"
                                },
                                new ProductDetail
                                {
                                    Id = 30,
                                    ProductId = 2,
                                    Passage = "دارای CAD مخصوص BMD و IVA"
                                },
                                new ProductDetail
                                {
                                    Id = 31,
                                    ProductId = 2,
                                    Passage = "استفاده از نرم افزار AccuView برای تشخیص دقیق لبه استخوان و بالا بردن دقت پوزیشن دهی"
                                },
                                new ProductDetail
                                {
                                    Id = 32,
                                    ProductId = 2,
                                    Passage = "توانایی merge کردن دیتابیس در دو یا بیش از دو دستگاه توسط نرم افزار همزمان کننده     DB SYNC"
                                },
                                new ProductDetail
                                {
                                    Id = 33,
                                    ProductId = 2,
                                    Passage = "منطبق بر پروتکل DICOM 3، امکان دریافت اطلاعات بیمار از سیستم های RIS/HIS و ارسال گزارشات و تصاویر به PACS"
                                },
                                new ProductDetail
                                {
                                    Id = 34,
                                    ProductId = 2,
                                    Passage = "امکان آنالیزاتوماتیک LOW BMD در ستون فقرات و هیپ"
                                },
                                new ProductDetail
                                {
                                    Id = 35,
                                    ProductId = 2,
                                    Passage = "ارزیابی بیماران با شاخص(FMI)  Fat mass index در اسکن تمام بدن"
                                },
                                new ProductDetail
                                {
                                    Id = 36,
                                    ProductId = 2,
                                    Passage = "نرم افزار INNERCORE برای ارزیابی Visceral adipose tissue"
                                },
                                new ProductDetail
                                {
                                    Id = 37,
                                    ProductId = 2,
                                    Passage = "کارایی بالای دستگاه با استفاده از دیتکتور دیجیتال  از جنس سرامیک و ژنراتور high frequency"
                                },
                                new ProductDetail
                                {
                                    Id = 38,
                                    ProductId = 2,
                                    Passage = "دارای نرم افزار های whole body، body composition،prosthetic hip،IVA ، Spine، hip، forearm، lateral spine، small animal، pediatrics"
                                },
                                new ProductDetail
                                {
                                    Id = 39,
                                    ProductId = 2,
                                    Passage = "قابلیت تشخیص  Atypical femur fracture(AFF) در مدل Horizn w، در بیمارانی که جهت درمان طولانی مدت Bisphophonaste مصرف می کنند و نیز بررسی ضخامت کورتکس در شفت فمور"
                                },
                                new ProductDetail
                                {
                                    Id = 40,
                                    ProductId = 2,
                                    Passage = "امکان استفاده از نرم افزار TBS "
                                }
                            }
                        };
                        lst = new List<Product>();
                        lst.Add(product);
                    }
                    break;
                case "c-arm":
                    {
                        Product product = new Product
                        {
                            Id = 3,
                            ImageTitle = "مینی سی آرم دیجیتال",
                            ImagePassage = " مدل FLUOROSCAN InSight FD",
                            ImageUrl = @"/assets/img/Imaging/c-arm.png",
                            ImageAlt = "c-arm",
                            ProductDetails = new List<ProductDetail>()
                            {
                                new ProductDetail
                                {
                                    Id = 41,
                                    ProductId = 3,
                                    Passage = ""
                                },
                                new ProductDetail
                                {
                                    Id = 42,
                                    ProductId = 3,
                                    Passage = "طراحی شده برای جراحیهای اورتوپدی، اندام فوقانی و تحتانی"
                                },
                                new ProductDetail
                                {
                                    Id = 43,
                                    ProductId = 3,
                                    Passage = "دقت و قدرت مانور بالا در طراحی جدید دستگاه مینی سی آرم"
                                },
                                new ProductDetail
                                {
                                    Id = 44,
                                    ProductId = 3,
                                    Passage = "وزن سبک، حمل و نقل آسان دستگاه"
                                },
                                new ProductDetail
                                {
                                    Id = 45,
                                    ProductId = 3,
                                    Passage = "الگوریتم جدید پردازش تصاویر با قابلیت ارائه تصاویری با کیفیت بالاترو بدون اعوجاج"
                                },
                                new ProductDetail
                                {
                                    Id = 46,
                                    ProductId = 3,
                                    Passage = "قابلیت تشخیص و تفکیک ایمپلنت ها در تصاویر"
                                },
                                new ProductDetail
                                {
                                    Id = 47,
                                    ProductId = 3,
                                    Passage = "دارای کوچکترین نقطه کانونی موجود در بازار( 0.045 میلیمتر) و درنتیجه دقت بسیار بالا در جراحیهای حساس و جراحیهای استخوانهای کوچک"
                                },
                                new ProductDetail
                                {
                                    Id = 48,
                                    ProductId = 3,
                                    Passage = "فلت پنل دیجیتال از جنس CMOS و پیکسل سایز 75 میکرون و رزولوشن 2000در1500"
                                },
                                new ProductDetail
                                {
                                    Id = 49,
                                    ProductId = 3,
                                    Passage = "120 درجه امکان چرخش منبع X-Ray"
                                },
                            },
                            CompleteInfo = new List<ProductDetail>()
                            {
                                new ProductDetail
                                {
                                    Id = 50,
                                    ProductId = 3,
                                    Passage = "استفاده از پدالهای wireless و Multi-functional"
                                },
                                new ProductDetail
                                {
                                    Id = 51,
                                    ProductId = 3,
                                    Passage = "منطبق برفرمت DICOM 3 ، امکان استفاده از USB/DVD ، امکان ارسال و ذخیره سازی تصاویر درPACS"
                                },
                                new ProductDetail
                                {
                                    Id = 52,
                                    ProductId = 3,
                                    Passage = "امکان چرخش دیتکتور و کالیماتور دستگاه در پوزیشن گیریهای مختلف عمل جراحی"
                                },
                            }
                        };
                        lst = new List<Product>();
                        lst.Add(product);
                    }
                    break;
                case "biopsy":
                    {
                        Product product = new Product
                        {
                            Id = 4,
                            ImageAlt = "biopsy",
                            ImageTitle = "ATEC Breast biopsy system for  Ultrasound",
                            ImagePassage = "کنسول وکیوم بایوپسی پستان",
                            ImageUrl = @"/assets/img/Imaging/biopsy.jpg",
                            ProductDetails = new List<ProductDetail>()
                            {
                                new ProductDetail
                                {
                                    Id = 53,
                                    ProductId = 4,
                                    Passage = "سیستم وکیوم بایوپسی پستان قابل استفاده تحت گاید اولتراسوند ( سونو گرافی ) ، استریوتاکتیک ( مامو گرافی )  و دستگاه   ام آر آِ یMRI"
                                },
                                new ProductDetail
                                {
                                    Id = 54,
                                    ProductId = 4,
                                    Passage = "امکان استفاده از  سوزن های  بسیار سبک و یکبار مصرف در سایزهای مختلف با کمترین میزان تهاجم "
                                },
                                new ProductDetail
                                {
                                    Id = 55,
                                    ProductId = 4,
                                    Passage = "کاهش احتمال هماتوم به علت شستشوی مداوم محل نمونه‌برداری"
                                },
                                new ProductDetail
                                {
                                    Id = 56,
                                    ProductId = 4,
                                    Passage = "انتخاب بهترین روش در انجام بایوپسی پستان با حداقل عمل تهاجمی بر روی بافت"
                                },
                                new ProductDetail
                                {
                                    Id = 57,
                                    ProductId = 4,
                                    Passage = "دقت و کنترل بالای عمل بایوپسی"
                                },
                                new ProductDetail
                                {
                                    Id = 58,
                                    ProductId = 4,
                                    Passage = " امکان برداشتن چندین نمونه در یک پروسه نمونه‌برداری"
                                },
                                new ProductDetail
                                {
                                    Id = 59,
                                    ProductId = 4,
                                    Passage = "کنترل درد بیمار در زمان انجام بایوپسی   "
                                },
                            },
                            CompleteInfo = new List<ProductDetail>()
                        };
                        lst = new List<Product>();
                        lst.Add(product);
                    }
                    break;
                case "needles":
                    {
                        Product product = new Product()
                        {
                            Id = 5,
                            ImageAlt = "celero",
                            ImageTitle = "ATEC Breast biopsy system for  Ultrasound",
                            ImagePassage = "کنسول وکیوم بایوپسی پستان",
                            ImageUrl = @"/assets/img/Imaging/Celero.png",
                            ProductDetails = new List<ProductDetail>()
                            {
                                new ProductDetail
                                {
                                    Id = 60,
                                    ProductId = 5,
                                    Passage = "کنترل بیشتر ، نمونه بزرگتر ، دسترسی آسان تر "
                                },
                                new ProductDetail
                                {
                                    Id = 61,
                                    ProductId = 5,
                                    Passage = "استفاده از  Celero Handpiece  برای بر داشتن نمو نه ها تحت گاید سونو گرافی بدون نیاز به دستگاه وکیوم بایوپسی  "
                                },
                                new ProductDetail
                                {
                                    Id = 62,
                                    ProductId = 5,
                                    Passage = "امکان دسترسی به ضایعات نزدیک به قفسه سینه ایمپلنت و نواحی زیر بغل )  گزیلاری )"
                                },
                                new ProductDetail
                                {
                                    Id = 63,
                                    ProductId = 5,
                                    Passage = "No Throw Option برای دستیابی به ضایعات نزدیک به Nipple,Axilla , Chest wall و ایمپلنت پستان  "
                                },
                                new ProductDetail
                                {
                                    Id = 64,
                                    ProductId = 5,
                                    Passage = "مهمترین ویژگی منحصر بفرد این سوزن  برداشتن نمونه به میزان دو برابر سایر روشهای متداول SLC  میباشد  "
                                },
                                new ProductDetail
                                {
                                    Id = 65,
                                    ProductId = 5,
                                    Passage = "امکان استفاده از ATEC Handpiece به همراه دستگاه وکیوم بایوپسی  Sapphire  برای برداشتن نمونه ها تحت گاید اولتراسوند"
                                },
                            },
                            CompleteInfo = new List<ProductDetail>()
                        };
                        lst = new List<Product>();
                        lst.Add(product);
                        Product product2 = new Product()
                        {
                            Id = 5,
                            ImageAlt = "ATEC",
                            ImageTitle = "ATEC Breast Biopsy Device",
                            ImagePassage = "سوزن های بایوپسی پستان تحت گاید استریوتاکتیک ( مامو گرافی ) ",
                            ImageUrl = @"/assets/img/Imaging/ATEC.png",
                            ProductDetails = new List<ProductDetail>()
                            {
                                new ProductDetail
                                {
                                    Id = 66,
                                    ProductId = 6,
                                    Passage = "امکان استفاده از نیدلهای وکیوم با سیستمهای استر یو تاکتیک نشسته یا بحالت خوابیده پرون "
                                },
                                new ProductDetail
                                {
                                    Id = 67,
                                    ProductId = 6,
                                    Passage = "انجام کل پروسه نمونه برداری تنها در 30 ثانیه "
                                },
                                new ProductDetail
                                {
                                    Id = 68,
                                    ProductId = 6,
                                    Passage = "امکان دسترسی به ضایعات نزدیک به قفسه سینه ایمپلنت و نواحی زیر بغل )  گزیلاری )"
                                },
                                new ProductDetail
                                {
                                    Id = 69,
                                    ProductId = 6,
                                    Passage = "گسترده ترین سایز سوزن "
                                },
                                new ProductDetail
                                {
                                    Id = 70,
                                    ProductId = 6,
                                    Passage = "برداشتن نمونه با سوزن های کوچک با حداقل اسیب رسانی به بافت "
                                }
                            },
                            CompleteInfo = new List<ProductDetail>()
                        };
                        lst.Add(product2);
                        Product product3 = new Product
                        {
                            Id = 7,
                            ImageAlt = "eviva",
                            ImageTitle = "سوزن بایوپسی eviva",
                            ImagePassage = "",
                            ImageUrl = @"/assets/img/Imaging/eviva.png",
                            ProductDetails = new List<ProductDetail>()
                            {
                                new ProductDetail
                                {
                                    Id = 71,
                                    ProductId = 7,
                                    Passage = "سوزن بایوپسی Eviva   سازگار با تمامی سیستمهای بایوپسی استریو تاکتیک بوده "
                                },
                                new ProductDetail
                                {
                                    Id = 72,
                                    ProductId = 7,
                                    Passage = "سیستم firing  مستقل از اداپتور "
                                },
                                new ProductDetail
                                {
                                    Id = 73,
                                    ProductId = 7,
                                    Passage = "امکان اسان برای قرار گیری مارکر secur mark "
                                },
                                new ProductDetail
                                {
                                    Id = 74,
                                    ProductId = 7,
                                    Passage = "امکان فشرده سازی بافت تا 16 میلی متر و استفاده از نیدل petite  مناسب برای سینه های کوچک "
                                },
                                new ProductDetail
                                {
                                    Id = 75,
                                    ProductId = 7,
                                    Passage = "دسترسی آسانتر بهدنمونه های برداشته شده"
                                },
                            },
                            CompleteInfo = new List<ProductDetail>()
                        };
                        lst.Add(product3);
                    }
                    break;
                case "padmammo":
                    {
                        Product product = new Product
                        {
                            Id = 8,
                            ImageAlt = "padmammo",
                            ImageTitle = "سونوگرافی پرتابل پستان viera",
                            ImagePassage = "",
                            ImageUrl = @"/assets/img/Imaging/mammopad.png",
                            ProductDetails = new List<ProductDetail>()
                            {
                                new ProductDetail
                                {
                                    Id = 76,
                                    ProductId = 8,
                                    Passage = "ایجاد سطحی گرم بین بدن بیمار و گیرنده تصاویر و کمک به رهایی عضله پکتورال در حین تصویر برداری ",
                                },
                                new ProductDetail
                                {
                                    Id = 77,
                                    ProductId = 8,
                                    Passage = "کاهش استرس بیماران و انجام مامو گرافی بدون درد ",
                                },
                                new ProductDetail
                                {
                                    Id = 78,
                                    ProductId = 8,
                                    Passage = "کاهش ابراز نارضایتی بیماران تا 50 %  میزان",
                                },
                                new ProductDetail
                                {
                                    Id = 79,
                                    ProductId = 8,
                                    Passage = "قابلیت تصویر برداری قسمت بیشتری از قفسه سینه توسط اپراتور ",
                                },
                                new ProductDetail
                                {
                                    Id = 80,
                                    ProductId = 8,
                                    Passage = "اعمال فشار یکسان بروی بافت پستان",
                                },
                                new ProductDetail
                                {
                                    Id = 81,
                                    ProductId = 8,
                                    Passage = "دارای سطح طراحی شده برای ثابت نگه داشتن بافت جهت پوزیشن دهی راحت تر",
                                },
                            },
                            CompleteInfo = new List<ProductDetail>()
                        };
                        lst = new List<Product>();
                        lst.Add(product);
                    }
                    break;
                case "viera":
                    {
                        Product product = new Product()
                        {
                            Id = 9,
                            ImageAlt = "viera",
                            ImageTitle = "کنسول وکیوم بایوپسی و رادیوگرافی بایوپسی پستان",
                            ImagePassage = "",
                            ImageUrl = @"/assets/img/Imaging/viera.png",
                            ProductDetails = new List<ProductDetail>()
                            {
                                new ProductDetail
                                {
                                    Id = 82,
                                    ProductId = 9,
                                    Passage = "اولین سونو گرافی پرتابل پستان با بالاترین کیفیت بصورت wireless"
                                },
                                new ProductDetail
                                {
                                    Id = 83,
                                    ProductId = 9,
                                    Passage = "داشتن  تصاویر با بالاترین کیفیت  4-14MHZ "
                                },
                                new ProductDetail
                                {
                                    Id = 84,
                                    ProductId = 9,
                                    Passage = "قابلیت ارسال تصاویر بصورت wireless   بروی تمامی گوشیهای  هوشمند "
                                },
                                new ProductDetail
                                {
                                    Id = 85,
                                    ProductId = 9,
                                    Passage = "بهترین راهکار برای  داشتن تصاویر پستان در رادیولوژی تهاجمی  Intervention  مانند بایوپسی پستان ،وایرو مارکر گذاری "
                                },
                                new ProductDetail
                                {
                                    Id = 86,
                                    ProductId = 9,
                                    Passage = "قابلیت کاربرد برای سونوگرافی  پرتابل نواحی کوچک و عروق"
                                },
                            },
                            CompleteInfo = new List<ProductDetail>()
                        };
                        lst = new List<Product>();
                        lst.Add(product);
                    }
                    break;
                case "vaccum":
                    {
                        Product product = new Product()
                        {
                            Id = 10,
                            ImageAlt = "viera",
                            ImageTitle = "سونوگرافی پرتابل پستان viera",
                            ImagePassage = "",
                            ImageUrl = @"/assets/img/Imaging/vaccum.png",
                            CompleteInfo = new List<ProductDetail>(),
                            ProductDetails = new List<ProductDetail>()
                            {
                                new ProductDetail
                                {
                                    Id = 87,
                                    ProductId = 10,
                                    Passage = "سیستم وکیوم بایوپسی تصویربرداری پستان کاملا دیجیتال"
                                },
                                new ProductDetail
                                {
                                    Id = 88,
                                    ProductId = 10,
                                    Passage = "دارای دیتکتور آمورفوس سلنیوم Se-a "
                                },
                                new ProductDetail
                                {
                                    Id = 89,
                                    ProductId = 10,
                                    Passage = "امکان انجام بایوپسی و تصویر برداری از نمونه بایوپسی بطورهمزمان در کوتاه ترین زمان"
                                },
                                new ProductDetail
                                {
                                    Id = 90,
                                    ProductId = 10,
                                    Passage = " رضایتمندی بیشتر برای پزشک و بیمار "
                                },
                                new ProductDetail
                                {
                                    Id = 91,
                                    ProductId = 10,
                                    Passage = "کوتاه شدن زمان کمپرسور برای بیمار"
                                },
                            }
                        };
                        lst = new List<Product>();
                        lst.Add(product);
                    }
                    break;
                case "affirm":
                    {
                        Product product = new Product()
                        {
                            Id = 11,
                            ImageAlt = "affirm",
                            ImageTitle = "سیستم بایوپسی استریوتاکتیک پستان به روش پرون 3D – D2",
                            ImagePassage = "System Affirm prone Breast Biopsy",
                            ImageUrl = @"/assets/img/Imaging/affirm.png",
                            CompleteInfo = new List<ProductDetail>(),
                            ProductDetails = new List<ProductDetail>()
                            {
                                new ProductDetail
                                {
                                    Id = 92,
                                    ProductId = 11,
                                    Passage = "اولین سیستم تخصصی بایوپسی پستان بروش پرون ( خوابیده به شکم ) با قابلیت تصویر برداری دو بعدی – سه بعدی "
                                },
                                new ProductDetail
                                {
                                    Id = 93,
                                    ProductId = 11,
                                    Passage = "نمونـه بـرداری از بافت پستان با حداقـل آسیب‌رسانی بـه بافـت"
                                },
                                new ProductDetail
                                {
                                    Id = 94,
                                    ProductId = 11,
                                    Passage = "میدان دید14.3 CM X 11.7 CMبا استفاده از دتکتور دیجیتال "
                                },
                                new ProductDetail
                                {
                                    Id = 95,
                                    ProductId = 11,
                                    Passage = " تعیین مختصات و محل دقیق ضایعات در سه محور Z، Y، X "
                                },
                                new ProductDetail
                                {
                                    Id = 96,
                                    ProductId = 11,
                                    Passage = " هدفیابی بسیار دقیق ضایعات با دقت 1 ±میلیمتر "
                                },
                                new ProductDetail
                                {
                                    Id = 96,
                                    ProductId = 11,
                                    Passage = " چرخش کامل 180 C-Arm درجه "
                                },
                                new ProductDetail
                                {
                                    Id = 96,
                                    ProductId = 11,
                                    Passage = "360 درجه دسترسی واقعی به بافت پستان "
                                },
                                new ProductDetail
                                {
                                    Id = 96,
                                    ProductId = 11,
                                    Passage = " امکان اخذ تصاویر استریو در حین انجام بایوپسی "
                                },
                            }
                        };
                        lst = new List<Product>();
                        lst.Add(product);
                    }
                    break;
                default:
                    {
                        lst = new List<Product>();
                    }
                    break;
            }
            return View(lst);
        }
        public IActionResult Laboratory(string name)
        {
            List<Product> lst;
            switch (name)
            {
                case "bactec":
                    {
                        Product product = new Product()
                        {
                            Id = 10,
                            ImageTitle = "دستگاه کشت خون اتوماتیک",
                            ImagePassage = "BD Bactec",
                            ImageUrl = @"/assets/img/bactec-fx.webp",
                            ImageAlt = "Bactec",
                            ProductDetails = new List<ProductDetail>()
                            {
                               new ProductDetail
                               {
                                   Id = 91,
                                   ProductId = 10,
                                   Passage = "دستگاه کشت خون اتوماتیک BD BACTEC با استفاده از تکنیک فلورسانس و الگوریتم های تشخیصی متعدد با دقت یک میکروارگانیسم در میلی لیتر در زمان بسیار کوتاه، از سه ساعت پس از کشت تا سه روز، نتیجه ی کشت خون مثبت را گزارش می کند (85% از نمونه هاي مثبت طی ٢٤ ساعت اول کشت مشخص مي شوند) و نتایج منفی در پایان روز پنجم کشت با اطمینان از عدم حضور میکروارگانیسم ها گزارش می گردند."
                               },
                               new ProductDetail
                               {
                                   Id = 92,
                                   ProductId = 10,
                                   Passage= "توانمندی در تشخیص انواع میکروارگانیسم بر پایه محیط کشت های مغذی است که از یک سو بستری مناسب برای رشد انواع باکتری های گرم مثبت، گرم منفی، هوازی و بیهوازی، انواع قارچها و مخمرها را فراهم می سازد و از سوی دیگر به علت دارا بودن دو نوع رزین(آب دوست/آب گریز) و بی اثر نمودن تمامی آنتی بيوتيك های محلول در خون، امکان رشد میکروارگانیسم ها را فراهم می آورد"
                               }
                            },
                            CompleteInfo = new List<ProductDetail>()
                            {
                               new ProductDetail
                               {
                                   Id = 93,
                                   ProductId = 10,
                                   Passage = "در واقع با بهره گیری از تکنولوژی رزین بدون نیاز به قطع پروسه درمان آنتی بیوتیکی امکان نمونه گیری و کشت خون مهیاست"
                               },
                               new ProductDetail
                               {
                                   Id = 94,
                                   ProductId = 10,
                                   Passage = "فناوری فلورسانس و استفاده از الگوریتم های اختصاصی تشخیص فاز رشد، امکان شناسایی گونه های کند رشد و یا گونه هایی که مقدار محدودی CO2 تولید می کنند را فراهم می آورد "
                               }
                            }
                        };
                        lst = new List<Product>();
                        lst.Add(product);
                        Product product2 = new Product()
                        {
                            Id = 10,
                            ImageTitle = "انواع ویال های کشت خون در سیستم ",
                            ImagePassage = "",
                            ImageUrl = @"/assets/img/Laboratory/vial.jpg",
                            ImageAlt = "Bactec",
                            ProductDetails = new List<ProductDetail>()
                            {
                               new ProductDetail
                               {
                                   Id = 91,
                                   ProductId = 10,
                                   Passage = "ويال Plus Aerobic/F : كليه ميكروارگانيسم هاي هوازی، ميكروائروفيل، قارچها و مخمرها در اين نوع ويال رشد مي كنند."
                               },
                               new ProductDetail
                               {
                                   Id = 91,
                                   ProductId = 10,
                                   Passage = "ويال Plus Anaerobic : ویال حاوی رزين و دارای محيطي مناسب جهت رشد انواع ميكروارگانيسم های بيهوازی است."
                               },
                            new ProductDetail
                               {
                                   Id = 92,
                                   ProductId = 10,
                                   Passage = "ويال Anaerobic lytic : دارای عامل لیز کننده ی گلبول های سفید و قرمز می باشد که میزان تشخیص ارگانیسم های فاگوسیت شده و درون سلولی را افزایش می دهد . در اين محيط علاوه بر باکتری های بی هوازی اجباری سرعت رشد ميكروارگانيسم های بی هوازی اختياری نيز افزايش چشمگيری دارد."
                               },
                               new ProductDetail
                               {
                                   Id = 93,
                                   ProductId = 10,
                                   Passage = "ويال ويژه اطفال Peds plusفرمولاسیون ویژه ویال های کشت خون اطفال درسیستم BD BACTEC باعث افزایش دقت و سرعت رشد عوامل سپسیس در کودکان می باشد و بسته به وزن نوزاد، امکان نمونه گیری از 0.5-3 cc وجود دارد. 99% ميكروارگانيسم هایی كه عامل عفونت خونی در اطفال مي باشند، قابليت رشد در اين نوع ويال را دارند."
                               },
                            },
                            CompleteInfo = new List<ProductDetail>()
                            {
                               new ProductDetail
                               {
                                   Id = 94,
                                   ProductId = 10,
                                   Passage = "ويال ويژه ما یکوباکتریوم Myco/F : ويال ويژه جهت تشخيص مايكوباكتريوم در نمونه خون و مايعات استريل است."
                               },
                               new ProductDetail
                               {
                                   Id = 94,
                                   ProductId = 10,
                                   Passage = "ويال ويژه قارچها Mycosis  : ويال تخصصي جهت تشخيص و رشد سريع ٧٢ نوع مخمر و قارچ پاتوژن می باشد"
                               }
                            }
                        };
                        lst.Add(product2);
                    }
                    break;
                case "phoenix":
                    {
                        lst = new List<Product>();
                        Product product = new Product()
                        {
                            Id = 11,
                            ImageTitle = "سیستم اتوماتیک تعیین هویت و تعیین حساسیت آنتی بیوتیکی(آنتی بیوگرام)",
                            ImagePassage = "معتبرترین سیستم برای تعیین مقاومت میکروبی",
                            ImageUrl = @"/assets/img/Laboratory/phoenix.webp",
                            ImageAlt = "phoenix",
                            ProductDetails = new List<ProductDetail>
                            {
                                new ProductDetail
                                {
                                    Id = 97,
                                    ProductId = 11,
                                    Passage = "اقدامات موثر درکنترل عفونت ها، بستگی به عملکرد آزمایشگاه در تشخیص صحیح ID و تعیین دقیق AST در سریع ترین زمان ممکن دارد"
                                },
                                new ProductDetail
                                {
                                    Id = 97,
                                    ProductId = 11,
                                    Passage = "BD Phoenix با تکنولوژی منحصر به فرد خود به آزمایشگاه های میکروبیولوژی امکان انجام همزمان ID و AST با دقیق ترین و سریع ترین روش ممکن را می دهد."
                                },
                                new ProductDetail
                                {
                                    Id = 97,
                                    ProductId = 11,
                                    Passage = "سیستم BD Phoenix با پنل های ویژه قادر است تا هویت بیش از 160 گونه باکتری گرم منفی و 140 گونه باكتري گرم مثبت و 64 نوع قارچ و مخمر را در كمتر از ١۰ ساعت تعیین نمايد."
                                },
                            },
                            CompleteInfo = new List<ProductDetail>()
                            {
                                new ProductDetail
                                {
                                    Id = 97,
                                    ProductId = 11,
                                    Passage = "این سیستم با تکنولوژی دوگانه هر20  دقیقه چاهک ها را از نظرRedox  (اکسیداسیون - احیا) و Turbidity (کدورت سنجی) مورد بررسی قرار می دهد. در واقع نه تنها رشد باکتری ها، بلکه سوخت و ساز آنها را نیز بررسی می کند. "
                                },
                                new ProductDetail
                                {
                                    Id = 97,
                                    ProductId = 11,
                                    Passage = "تعیین MIC )حداقل غلظت ممانعت کنندگی( بر اساس استاندارد CLSI یا EUCAST : در تمامی پنل های BD Phoenix با رقت سازی های سریالی، حداقل 3 و حداکثر 8 غلظت برای هر آنتی بیوتیک، MIC تعیین می شود."
                                },
                                new ProductDetail
                                {
                                    Id = 97,
                                    ProductId = 11,
                                    Passage = "طراحی پنل با تکنولوژی دوگانه  (Redox,Turbidtiy)در کنار تعیین MIC، امکان تشخیص مقاومت های تاخیری را فراهم می آورد."
                                },
                            }
                        };
                        lst.Add(product);
                        Product product2 = new Product()
                        {
                            Id = 11,
                            ImageTitle = "انواع پنل های BD Phoenix",
                            ImagePassage = "",
                            ImageUrl = @"/assets/img/Laboratory/phoenixpanel2.png",
                            ImageAlt = "phoenix panel",
                            ProductDetails = new List<ProductDetail>()
                            {
                                new ProductDetail
                                {
                                    Id = 11,
                                    ProductId = 11,
                                    Passage = "پنل های تعیین ID (باکتری های گرم منفی، باکتری های گرم مثبت و مخمر)"
                                },
                                new ProductDetail
                                {
                                    Id = 11,
                                    ProductId = 11,
                                    Passage = "پنل های تعیین AST (باکتری های گرم منفی، استرپتوکوک ها، باکتری های گرم مثبت و Emerge)"
                                },
                                new ProductDetail
                                {
                                    Id = 11,
                                    ProductId = 11,
                                    Passage = "تعیین ID : از میان سیستم های اتوماتیک تعیین هویت(ID)، BD Phoenix بالاترین درصد تشخیص صحیح را دارا می باشد و همچنین تنها سیستم اتوماتیکی است که تشخیص اشتباه ندارد.(0%)"
                                },
                            },
                            CompleteInfo = new List<ProductDetail>()
                        };
                        lst.Add(product2);
                        Product product3 = new Product()
                        {
                            Id = 11,
                            ImageTitle = "انواع پنل های BD Phoenix",
                            ImagePassage = "",
                            ImageUrl = @"/assets/img/Laboratory/phoenixpanel1.png",
                            ImageAlt = "phoenix panel",
                            ProductDetails = new List<ProductDetail>()
                            {
                                new ProductDetail
                                {
                                    Id = 11,
                                    ProductId = 11,
                                    Passage = "پنل های تعیین AST (باکتری های گرم منفی، استرپتوکوک ها، باکتری های گرم مثبت و Emerge)"
                                },
                                new ProductDetail
                                {
                                    Id = 11,
                                    ProductId = 11,
                                    Passage = "تعیین AST : در هر پنل (COMBINATION ID + AST ) Combo ، 84 چاهک (Well) با  19-23آنتی بیوتیک به تعیین AST اختصاص داده شده است ."
                                },
                                new ProductDetail
                                {
                                    Id = 11,
                                    ProductId = 11,
                                    Passage = "در هر پنلEmerge ، 132 چاهک با 30-31 آنتی بیوتیک برای تعیین AST اختصاص داده شده است که دارای آنتی بیوتیک ها و رقت های بیشتری می باشد.(رنج های گسترده تر MIC، برای انطباق با EUCAST و CLSI و تشخیص بروز مقاومت با گستره ی انتخابی وسیع آنتی بیوتیک ها)"
                                }
                            },
                            CompleteInfo = new List<ProductDetail>()
                        };
                        lst.Add(product3);
                    }
                    break;
                case "panther":
                    {
                        lst = new List<Product>();
                        Product product = new Product()
                        {
                            Id = 11,
                            ImageTitle = "سیستم تمام اتوماتیک Panther",
                            ImagePassage = "",
                            ImageUrl = @"/assets/img/Laboratory/Panther.png",
                            ImageAlt = "panther",
                            ProductDetails = new List<ProductDetail>()
                            {
                                new ProductDetail
                                {
                                     Id = 12,
                                     ProductId = 11,
                                     Passage = "رویکرد اصلی کمپانی HOLOGIC، تندرستی و بهبود سلامت در زنان از طریق تشخیص زود هنگام و درمان به موقع بیماری های مرتبط با آنهاست."
                                },
                                new ProductDetail
                                {
                                    Id=12,
                                    ProductId =12,
                                    Passage = "سرطان سرویکس یکی از شایع ترین انواع سرطان درمیان زنان سراسر دنیاست.  HPVعامل اتیولوژیک بیش از 99% از سرطان های دهانه ی رحم است و معمولا تا مراحل پیشرفته بیماری بدون علامت می باشد. لذا مهمترین مسئله در کنترل و جلوگیری از بروز سرطان سرویکس، غربالگری منظم با استفاده از آزمایش های مولکولی معتبر با حساسیت و اختصاصیت بالاست."
                                },
                                new ProductDetail
                                {
                                    Id = 12,
                                    ProductId =13,
                                    Passage = "HPV با بیش از 100 نوع ژنوتایپ، ویروس بدون پوشش با DNA دو رشته ای حلقوی است. و انواع تومورهای بدخیم و خوش خیم را در پوست و مخاطات انسان ایجاد می کند."
                                },
                            },
                            CompleteInfo = new List<ProductDetail>()
                            {
                                new ProductDetail
                                {
                                    Id = 12,
                                    ProductId =13,
                                    Passage = "برای بیماریزایی، نیاز است که ویروس HPV به صورت خطی درآمده و وارد ژنوم میزبان شود. در طی فرایند خطی شدن ژنوم ویروس، ممکن است قسمتی از ژنوم آن حذف گردد، اما برای عملکرد آنکوژنیک ویروس HPV، حضور ژنهای E6 و E7  ضروریست."
                                },
                                new ProductDetail
                                {
                                    Id = 12,
                                    ProductId =13,
                                    Passage = "از آنجایی که ژن های E6 و E7 به عنوان اصلی ترین ژن های سرطان زای ویروسی شناخته می شوند و نقش مهمی در ترانسفورماسیون سلول های ناحیه سرویکس به سمت سلول های بدخیم و سرطانی دارند، بهترین و اختصاصی ترین روش تشخیص HPV بر اساس شناسایی ژن های E6 و E7 در mRNA ویروسی می باشد. "
                                },
                                new ProductDetail
                                {
                                    Id = 12,
                                    ProductId =13,
                                    Passage = "Aptima HPV Assay اولین کیت تایید شده توسط FDA برای تشخیص ویروس پاپیلوماست و از تکنیک Transcription Mediated Amplification (TMA)  Hybridization Protection Assay, (HPA) و Dual Kinetic Assay (DKA) برای تشخیص ژن های E6 و E7 در mRNA ویروسی استفاده می کند."
                                },
                                new ProductDetail
                                {
                                    Id = 12,
                                    ProductId =12,
                                    Passage = "آزمایش Aptima HPV 16/18/45 Genotype Assay، نیز دارای تاییدیه FDA می باشد."
                                },
                                new ProductDetail
                                {
                                    Id = 12,
                                    ProductId=12,
                                    Passage="کیت های تشخیصی Aptima HPV دارای اینترنال کنترل(Internal Control) برای بررسی صحت انجام فرایند تشخیص هستند و بدون Cross Reactivity با ژنوتایپ های کم خطر، 14 نوع HPV پرخطر را شناسایی می کنند:"
                                }
                            }
                        };
                        lst.Add(product);
                    }
                    break;
                case "flow":
                    {
                        lst = new List<Product>();
                        Product product = new Product()
                        {
                            Id = 11,
                            ImageTitle = "BD Accuri C6 Plus",
                            ImagePassage = "",
                            ImageUrl = @"/assets/img/Laboratory/flow.jpg",
                            ImageAlt = "thinprep",
                            ProductDetails = new List<ProductDetail>()
                            {
                                new ProductDetail
                                {
                                    Id = 12,
                                    ProductId = 12,
                                    Passage = "دستگاه  آنالایزربا دو لیزر ، تشخیص 4 رنگ و 6 پارامتر"
                                },
                                new ProductDetail
                                {
                                    Id = 12,
                                    ProductId = 12,
                                    Passage = "  پرتابل با وزن 13.6 کیلوگرم Accuri C6 Plus"
                                },
                                new ProductDetail
                                {
                                    Id = 12,
                                    ProductId = 12,
                                    Passage = "کاربری ساده دستگاه – این دستگاه نیاز به تنظیم ولتاژ ندارد "
                                },
                                new ProductDetail
                                {
                                    Id = 12,
                                    ProductId = 12,
                                    Passage = "قابلیت خوانش انواع لوله ها با سایز های گوناگون "
                                },
                                new ProductDetail
                                {
                                    Id = 12,
                                    ProductId = 12,
                                    Passage = " اعلام تعداد مطلق سلولها در واحد میکرولیتر نمونه (غلظت سلولها) "
                                },
                            },
                            CompleteInfo = new List<ProductDetail>()
                            {
                                new ProductDetail
                                {
                                    Id = 12,
                                    ProductId = 12,
                                    Passage = "دارای بیدهای کالیبراسیون اتوماتیک روزانه دستگاه"
                                },
                                new ProductDetail
                                {
                                    Id = 12,
                                    ProductId = 12,
                                    Passage = "قابلیت اتصال به auto sampler جهت قرائت اتوماتیک نمونه ها "
                                },
                                new ProductDetail
                                {
                                    Id = 12,
                                    ProductId = 12,
                                    Passage = "این دستگاه می تواند تا 10000 ذره در ثانیه را قرائت نماید"
                                }
                            }
                        };
                        lst.Add(product);
                    }
                    break;
                case "thinprep":
                    {
                        lst = new List<Product>();
                        Product product = new Product()
                        {
                            Id = 11,
                            ImageTitle = "ThinPrep",
                            ImagePassage = "",
                            ImageUrl = @"/assets/img/Laboratory/thinprep.jpg",
                            ImageAlt = "thinprep",
                            ProductDetails = new List<ProductDetail>()
                            {
                                new ProductDetail
                                {
                                    Id = 12,
                                    ProductId =12,
                                    Passage="دستگاه تمام اتوماتیک تهیه ی لام تین پرپ (ThinPrep) روشی استاندارد برای تهیه ی اسلایدهای سلولی یکنواخت جهت بررسی های سیتولوژی پاپ اسمیر، FNA (تیروئید ، پستان، غدد لنفاوی و...) مایعات و مخاط بدن را فراهم می آورد. "
                                },
                                new ProductDetail
                                {
                                    Id = 12,
                                    ProductId =12,
                                    Passage="اولین تست پاپ اسمیر مایع (liquid-based) که موفق به اخذ گواهی FDA برای تشخیص HPV ، کلامیدیا ، گونوره آ و تریکومونازیس بر روی یک ویال شد."
                                },
                                new ProductDetail
                                {
                                    Id = 12,
                                    ProductId =12,
                                    Passage="در روش ThinPrep صد در صد سلولهای جمع آوری شده از سرویکس به ویال های مخصوص ThinPrep منتقل و نگهداری می شوند. در حالیکه در روش پاپ اسمیر کلاسیک اکثر سلول ها به همراه ابزار نمونه گیری دور ریخته می شود ."
                                },
                            },
                            CompleteInfo = new List<ProductDetail>()
                            {
                                new ProductDetail
                                {
                                    Id = 12,
                                    ProductId =12,
                                    Passage="در طی مراحل آماده سازی، خون، موکوس و سایر مواد زاید از سلولها جدا می شوند."
                                },
                                new ProductDetail
                                {
                                    Id = 12,
                                    ProductId =12,
                                    Passage="به علت استفاده از ویال های حاوی نگهدارنده و عدم نیاز به سانتریفیوژ (استفاده از فیلترهای مخصوص)، مورفولوژی سلول ها حفظ می گردد."
                                },new ProductDetail
                                {
                                    Id = 12,
                                    ProductId =12,
                                    Passage="به علت فرآیند آماده سازی اتوماتیک نمونه ها، اسلاید های واضح با توزیع یکنواخت سلولی و رنگ آمیزی با زمینه ی روشن و شفاف حاصل می شود."
                                },
                                new ProductDetail
                                {
                                    Id = 12,
                                    ProductId =12,
                                    Passage="سیستم ThinPrep حساسیت و اختصاصیت بسیار بالاتری نسبت به روش دستی پاپ اسمیر دارد."
                                },
                                new ProductDetail
                                {
                                    Id = 12,
                                    ProductId =12,
                                    Passage="نتایج آزمایشات بالینی افزایش معنا داری در میزان حساسیت ASCUS و اختصاصیتHSIL  و LSIL نشان می دهد ."
                                },
                                new ProductDetail
                                {
                                    Id = 12,
                                    ProductId =12,
                                    Passage="روشی اتوماتیک، استاندارد و دارای تاییدیه FDA برای بررسی های سیتولوژیک"
                                },
                                new ProductDetail
                                {
                                    Id = 12,
                                    ProductId =12,
                                    Passage="Test ThinPrep Pap ، تنها آزمایش مورد تأیید FDA برای انجام پاپ اسمیر و HPV از طریق یک ویال "
                                },
                                new ProductDetail
                                {
                                    Id = 12,
                                    ProductId =12,
                                    Passage="حفظ مورفولوژی سلول ها و کیفیت بالای نمونه به علت استفاده از ویال های حاوی نگهدارنده"
                                },
                                new ProductDetail
                                {
                                    Id = 12,
                                    ProductId =12,
                                    Passage="افزایش حساسیت و اختصاصیت "
                                },
                                new ProductDetail
                                {
                                    Id = 12,
                                    ProductId =12,
                                    Passage="اسلاید های واضح و یکنواخت از نظر سلول و رنگ آمیزی با زمینه ی روشن و شفاف"
                                },
                                new ProductDetail
                                {
                                    Id = 12,
                                    ProductId =12,
                                    Passage="عدم نیاز به سانتریفیوژ (به علت استفاده از فیلترهای مخصوص)"
                                },
                                new ProductDetail
                                {
                                    Id = 12,
                                    ProductId =12,
                                    Passage="صرفه جویی در زمان و هزینه ی آماده سازی لام ها"
                                }
                            }
                        };
                        lst.Add(product);
                    }
                    break;
                case "fibro":
                    {
                        lst = new List<Product>();
                        Product product = new Product
                        {
                            Id = 11,
                            ImageTitle = "تست فیبرونکتین جنینی",
                            ImagePassage = "پیشگویی کننده بیوشیمیایی زایمان زودرس",
                            ImageUrl = @"/assets/img/Laboratory/FFN.jpg",
                            ImageAlt = "fibro",
                            ProductDetails = new List<ProductDetail>()
                            {
                                new ProductDetail
                                {
                                    Id = 12,
                                    ProductId = 12,
                                    Passage = "فیبرونکتین جنینی یک گلیکوپروتئین چسبناک در سطح مشترک مادری-جنینی است. وجود این پروتئین در ترشحات واژینال طی هفته های 22 تا 34 بارداری، بیانگر افزایش خطر زایمان زودرس می باشد."
                                },
                                new ProductDetail
                                {
                                    Id = 12,
                                    ProductId = 12,
                                    Passage = "آزمایش فیبرونکتین جنینی روشی غیرتهاجمی است که با یک نمونه گیری ساده از ترشحات رحمی خطر وقوع زایمان زودرس را پیش بینی میکند."
                                },
                                new ProductDetail
                                {
                                    Id = 12,
                                    ProductId = 12,
                                    Passage = "سالانه تقریبا 15 میلیون نوزاد نارس در سراسر دنیا متولد می شود. زایمان زودرس طبق تعریف WHO به زایمان پیش از هفته 37 ام بارداری اطلاق می شود و مسبب اکثر معضلات غیر کروموزومی و مرگ و میر نوزادان است."
                                },
                                new ProductDetail
                                {
                                    Id = 12,
                                    ProductId = 12,
                                    Passage = "بر اساس مطالعه ای که به مدت 3 سال بر روی 2900 خانم در سنین بارداری 22 تا 24 هفته انجام شده است فیبرونکتین جنینی بهترین آزمایش برای پیش بینی زایمان زودرس پیش از هفته 32 بارداری است."
                                }
                            },
                            CompleteInfo = new List<ProductDetail>()
                            {
                                new ProductDetail
                                {
                                    Id = 12,
                                    ProductId = 12,
                                    Passage = "آزمایش فیبرونکتین جنینی روشی غیرتهاجمی است که با یک نمونه گیری ساده از ترشحات رحمی خطر وقوع زایمان زودرس را پیش بینی میکند."
                                },
                                new ProductDetail
                                {
                                    Id = 12,
                                    ProductId = 12,
                                    Passage = " اقدامات درمانی بهتر برای زنانی که در معرض بیشترین خطر زایمان زودرس هستند اتخاذ می گردد."
                                },
                                new ProductDetail
                                {
                                    Id = 12,
                                    ProductId = 12,
                                    Passage = "در صورت نتیجه منفی تست با احتمال %99.2 اطمینان از عدم شروع زایمان در 14 روز آینده سبب :"
                                },
                                new ProductDetail
                                {
                                    Id = 12,
                                    ProductId = 12,
                                    Passage = "85% کاهش استفاده از کورتیکواستروئیدها"
                                },
                                new ProductDetail
                                {
                                    Id = 12,
                                    ProductId = 12,
                                    Passage = "84% کاهش هزینه های بیمارستانی"
                                },
                                new ProductDetail
                                {
                                    Id = 12,
                                    ProductId = 12,
                                    Passage = "81% کاهش متوسط تعداد روزهای بستری در بیمارستان"
                                },
                                new ProductDetail
                                {
                                    Id = 12,
                                    ProductId = 12,
                                    Passage = "64% کاهش استفاده از توکولیتیک ها می گردد"
                                }
                            }
                        };
                        lst.Add(product);
                    }
                    break;
                case "vaccum":
                    {
                        lst = new List<Product>();
                        Product product = new Product
                        {
                            Id = 11,
                            ImageTitle = "",
                            ImagePassage = "",
                            ImageUrl = @"/assets/img/Laboratory/vaccum.jpg",
                        };
                        lst.Add(product);
                    }
                    break;
                default:
                    {
                        lst = new List<Product>();
                    }
                    break;
            }
            return View(lst);
        }
        public IActionResult JoinUs()
        {
            return View();
        }
        public IActionResult ImagingCard()
        {
            return View();
        }
        public IActionResult LaboratoryCard()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
