using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types.ReplyMarkups;
using System.IO;

namespace Tg_Bot.ServiceClass
{
    class ButtonGenerator
    {
        public IReplyMarkup GetKeyBoardButtons() {
            return new ReplyKeyboardMarkup
            {
                Keyboard = new List<List<KeyboardButton>>
                {
                    new List<KeyboardButton> { new KeyboardButton { Text = "📋Расписание!📋" } },
                    new List<KeyboardButton> { new KeyboardButton { Text = "📚Предметы!📚" } , new KeyboardButton { Text = "💻Конференции!💻" } },
                    new List<KeyboardButton> { new KeyboardButton { Text = "⁉️Вопрос-Ответ!⁉️" } },
                    new List<KeyboardButton> { new KeyboardButton { Text = "📲Связь!📲" } },
                    new List<KeyboardButton> { new KeyboardButton { Text = "💰На Сервер!💰" } }
                }
            };
        }

        public InlineKeyboardButton GetInlineButton_QuestionAnswe()
        {
            InlineKeyboardButton button = new InlineKeyboardButton();

            button.Text = "Чат для вопросов!";
            using (FileStream fstream = new FileStream(FileName.QuesAnsw, FileMode.Open))
            using (StreamReader reader = new StreamReader(fstream)) 
            button.Url = reader.ReadLine();

            return button;
        }

        public InlineKeyboardMarkup GetInlineButtons_TimeTable()
        {
            return new InlineKeyboardMarkup(new[]
                            {
                        new[]
                        {
                            InlineKeyboardButton.WithCallbackData(
                                text: "Расписание по числителю!",
                                callbackData: new InlineData(){
                            Button = Enumerate.TypeOfButton.TimeTable,
                            Week = Enumerate.TypeOfWeek.Numerator,
                            Day = Enumerate.TypeOfDay.None,
                            Lesson = Enumerate.TypeOfLesson.None
                            }.Crypt())
                        },
                        new[]
                        {
                            InlineKeyboardButton.WithCallbackData(
                                text:"Расписание по знаменателю!",
                                callbackData: new InlineData(){
                            Button = Enumerate.TypeOfButton.TimeTable,
                            Week = Enumerate.TypeOfWeek.Denominator,
                            Day = Enumerate.TypeOfDay.None,
                            Lesson = Enumerate.TypeOfLesson.None
                            }.Crypt())
                        },
                        new[]
                        {
                            InlineKeyboardButton.WithCallbackData(
                                text: "Расписание звонков!", 
                                callbackData: new InlineData(){
                            Button = Enumerate.TypeOfButton.TimeTable,
                            Week = Enumerate.TypeOfWeek.Call_,
                            Day = Enumerate.TypeOfDay.None,
                            Lesson = Enumerate.TypeOfLesson.None
                            }.Crypt())
                        }
                     });
        }

        public InlineKeyboardMarkup GetInlineButtons_Lessons()
        {
            return new InlineKeyboardMarkup(new[]
                            {
                            new[]
                            {
                                InlineKeyboardButton.WithCallbackData(
                                    text: "ДСіПЗ",
                                    callbackData: new InlineData(){
                            Button = Enumerate.TypeOfButton.Lessons,
                            Week = Enumerate.TypeOfWeek.None,
                            Day = Enumerate.TypeOfDay.None,
                            Lesson = Enumerate.TypeOfLesson.DSPZ
                                }.Crypt()),
                                InlineKeyboardButton.WithCallbackData(
                                    text: "МАтаПЗ",
                                    callbackData: new InlineData(){
                            Button = Enumerate.TypeOfButton.Lessons,
                            Week = Enumerate.TypeOfWeek.None,
                            Day = Enumerate.TypeOfDay.None,
                            Lesson = Enumerate.TypeOfLesson.MAPZ
                                }.Crypt())
                            },
                            new[]
                            {
                                InlineKeyboardButton.WithCallbackData(
                                    text: "БД",
                                    callbackData: new InlineData(){
                            Button = Enumerate.TypeOfButton.Lessons,
                            Week = Enumerate.TypeOfWeek.None,
                            Day = Enumerate.TypeOfDay.None,
                            Lesson = Enumerate.TypeOfLesson.BD
                                }.Crypt()),
                                InlineKeyboardButton.WithCallbackData(
                                    text: "БЖД",
                                    callbackData: new InlineData(){
                            Button = Enumerate.TypeOfButton.Lessons,
                            Week = Enumerate.TypeOfWeek.None,
                            Day = Enumerate.TypeOfDay.None,
                            Lesson = Enumerate.TypeOfLesson.BJD
                                }.Crypt())
                            },
                            new[]
                            {
                                InlineKeyboardButton.WithCallbackData(
                                    text: "КПП",
                                    callbackData: new InlineData(){
                            Button = Enumerate.TypeOfButton.Lessons,
                            Week = Enumerate.TypeOfWeek.None,
                            Day = Enumerate.TypeOfDay.None,
                            Lesson = Enumerate.TypeOfLesson.KPP
                                }.Crypt()),
                                InlineKeyboardButton.WithCallbackData(
                                    text: "МПП",
                                    callbackData: new InlineData(){
                            Button = Enumerate.TypeOfButton.Lessons,
                            Week = Enumerate.TypeOfWeek.None,
                            Day = Enumerate.TypeOfDay.None,
                            Lesson = Enumerate.TypeOfLesson.MPP
                                }.Crypt()),
                            },
                            new[]
                            {
                                InlineKeyboardButton.WithCallbackData(
                                    text: "МОтаДО",
                                    callbackData: new InlineData(){
                            Button = Enumerate.TypeOfButton.Lessons,
                            Week = Enumerate.TypeOfWeek.None,
                            Day = Enumerate.TypeOfDay.None,
                            Lesson = Enumerate.TypeOfLesson.MODO
                                }.Crypt()),
                            }
                        });
        }

        public InlineKeyboardMarkup GetinlineKeyboard_Conf()
        {
            return new InlineKeyboardMarkup(new[]
                            {
                            new[]
                            {
                                InlineKeyboardButton.WithCallbackData(
                                    text: "ДСіПЗ",
                                    callbackData: new InlineData(){
                            Button = Enumerate.TypeOfButton.Conferences,
                            Week = Enumerate.TypeOfWeek.None,
                            Day = Enumerate.TypeOfDay.None,
                            Lesson = Enumerate.TypeOfLesson.DSPZ
                                }.Crypt()),
                                InlineKeyboardButton.WithCallbackData(
                                    text: "МАтаПЗ",
                                    callbackData: new InlineData(){
                            Button = Enumerate.TypeOfButton.Conferences,
                            Week = Enumerate.TypeOfWeek.None,
                            Day = Enumerate.TypeOfDay.None,
                            Lesson = Enumerate.TypeOfLesson.MAPZ
                                }.Crypt())
                            },
                            new[]
                            {
                                InlineKeyboardButton.WithCallbackData(
                                    text: "БД",
                                    callbackData: new InlineData(){
                            Button = Enumerate.TypeOfButton.Conferences,
                            Week = Enumerate.TypeOfWeek.None,
                            Day = Enumerate.TypeOfDay.None,
                            Lesson = Enumerate.TypeOfLesson.BD
                                }.Crypt()),
                                InlineKeyboardButton.WithCallbackData(
                                    text: "БЖД",
                                    callbackData: new InlineData(){
                            Button = Enumerate.TypeOfButton.Conferences,
                            Week = Enumerate.TypeOfWeek.None,
                            Day = Enumerate.TypeOfDay.None,
                            Lesson = Enumerate.TypeOfLesson.BJD
                                }.Crypt())
                            },
                            new[]
                            {
                                InlineKeyboardButton.WithCallbackData(
                                    text: "КПП",
                                    callbackData: new InlineData(){
                            Button = Enumerate.TypeOfButton.Conferences,
                            Week = Enumerate.TypeOfWeek.None,
                            Day = Enumerate.TypeOfDay.None,
                            Lesson = Enumerate.TypeOfLesson.KPP
                                }.Crypt()),
                                InlineKeyboardButton.WithCallbackData(
                                    text: "МПП",
                                    callbackData: new InlineData(){
                            Button = Enumerate.TypeOfButton.Conferences,
                            Week = Enumerate.TypeOfWeek.None,
                            Day = Enumerate.TypeOfDay.None,
                            Lesson = Enumerate.TypeOfLesson.MPP
                                }.Crypt()),
                            },
                            new[]
                            {
                                InlineKeyboardButton.WithCallbackData(
                                    text: "МОтаДО",
                                    callbackData: new InlineData(){
                            Button = Enumerate.TypeOfButton.Conferences,
                            Week = Enumerate.TypeOfWeek.None,
                            Day = Enumerate.TypeOfDay.None,
                            Lesson = Enumerate.TypeOfLesson.MODO
                                }.Crypt()),
                            }
                            });
        }

        public InlineKeyboardMarkup GetinlineKeyboard_DayOfWeek(InlineData data)
        {
            return new InlineKeyboardMarkup(new[]
            {
            new[]
                {
                    InlineKeyboardButton.WithCallbackData(
                        text: "Пн", 
                        callbackData: new InlineData(){
                            Button = Enumerate.TypeOfButton.DayOfWeek,
                            Week = data.Week,
                            Day = Enumerate.TypeOfDay.Mo,
                            Lesson = Enumerate.TypeOfLesson.None
                                }.Crypt()), //for read from (for example NumeratorMonday.txt)
                    InlineKeyboardButton.WithCallbackData(
                        text: "Вт",
                        callbackData: new InlineData(){
                            Button = Enumerate.TypeOfButton.DayOfWeek,
                            Week = data.Week,
                            Day = Enumerate.TypeOfDay.Tu,
                            Lesson = Enumerate.TypeOfLesson.None
                                }.Crypt())
                },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData(
                        text: "Ср",
                        callbackData: new InlineData(){
                            Button = Enumerate.TypeOfButton.DayOfWeek,
                            Week = data.Week,
                            Day = Enumerate.TypeOfDay.We,
                            Lesson = Enumerate.TypeOfLesson.None
                                }.Crypt()),
                    InlineKeyboardButton.WithCallbackData(
                        text: "Чт", 
                        callbackData: new InlineData(){
                            Button = Enumerate.TypeOfButton.DayOfWeek,
                            Week = data.Week,
                            Day = Enumerate.TypeOfDay.Th,
                            Lesson = Enumerate.TypeOfLesson.None
                                }.Crypt())
                },
                  new[]
                {
                    InlineKeyboardButton.WithCallbackData(
                        text: "Пт", 
                        callbackData: new InlineData(){
                            Button = Enumerate.TypeOfButton.DayOfWeek,
                            Week = data.Week,
                            Day = Enumerate.TypeOfDay.Fr,
                            Lesson = Enumerate.TypeOfLesson.None
                                }.Crypt())
                }
            });
        }
    }
}
