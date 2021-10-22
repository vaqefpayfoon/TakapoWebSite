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
            Product product;
            switch (name)
            {
                case "mammography":
                    {
                        product = new Product
                        {
                            Id = 1,
                            ImageTitle = "مامو گرافی دیجیتال دوبعدی مدل",
                            ImagePassage = "Selenia Dimensions System  Avia 3000 Package",
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
                    }
                    break;
                case "horizon":
                    {
                        product = new Product
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
                    }
                    break;
                case "c-arm":
                    {
                        product = new Product
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
                    }
                    break;
                case "biopsy":
                    {
                        product = new Product
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
                    }
                    break;
                case "celero":
                    {
                        product = new Product()
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
                    }
                    break;
                case "ATEC":
                    {
                        product = new Product()
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
                    }
                    break;
                case "eviva":
                    {
                        product = new Product
                        {
                            Id = 7,
                            ImageAlt = "ATEC",
                            ImageTitle = "سوزن بایوپسی eviva",
                            ImagePassage = "",
                            ImageUrl = @"/assets/img/Imaging/ATEC.png",
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
                    }
                    break;
                case "padmammo":
                    {
                        product = new Product
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
                    }
                    break;
                case "viera":
                    {
                        product = new Product()
                        {
                            Id = 9,
                            ImageAlt = "viera",
                            ImageTitle = "سونوگرافی پرتابل پستان viera",
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
                    }
                    break;
                case "vaccum":
                    {
                        product = new Product()
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
                    }
                    break;
                case "affirm":
                    {
                        product = new Product()
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
                    }
                    break;
                default:
                    {
                        product = new Product
                        {
                            Id = 1000,
                            ImageUrl = "",
                            ImagePassage = "",
                            ImageTitle = "",
                            ProductDetails = new List<ProductDetail>()
                        };
                    }
                    break;
            }
            return View(product);
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
