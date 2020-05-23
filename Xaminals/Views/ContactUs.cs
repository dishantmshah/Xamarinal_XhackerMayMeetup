using System;
using Xamarin.Forms;
using Xamarin.Forms.Markup;
using Xamarin.Forms.Xaml;
using Xaminals.Common;
using static Xamarin.Forms.Markup.GridRowsColumns;

namespace Xaminals.Views
{
    public class ContactUs : ContentPage
    {
        Color BgClr = Color.FromHex("#FFFFFF");

        Style<Label> LabelStyle = new Style<Label>(
            (Label.TextColorProperty, Color.White)
        );

        public ContactUs() => Build();

        void Build()
        {

            this.Visual = VisualMarker.Material;

            Style<Frame> FrameStyle = new Style<Frame>(
                (Frame.HasShadowProperty, true),
                (Frame.BorderColorProperty, Color.FromHex("#333333"))

            );

            Style<Entry> EntryStyle = new Style<Entry>(
                (Entry.BackgroundColorProperty, Color.Transparent)
            );

            Resources = new ResourceDictionary();
            Resources.Add(LabelStyle);
            Resources.Add(FrameStyle);
            Resources.Add(EntryStyle);

            Title = "Contact Us";

            Content = new Grid()
            {
                RowDefinitions = Rows.Define(
                                (Row.Title, 44),
                                (Row.Content, Auto),
                                (Row.Push, Star)
                            ),
                RowSpacing = 0,
                Padding = new Thickness(30),
                BackgroundColor = Color.White,
                Children = {
                new Label
                            {
                                Text = "Contact",
                                FontSize = 24,
                                TextColor = Color.FromHex("#333333")
                            }
                .Row(Row.Title),


                            new Frame
                            {
                                CornerRadius = 0,
                                Padding = 12,
                                Content = new StackLayout
                                {
                                    Spacing = 12,
                                    Children =
                                    {
                                        new Entry
                                        {
                                            Placeholder = "Name:",
                                        },
                                        new Entry
                                        {
                                            Placeholder = "Email:"
                                        },
                                        new Entry
                                        {
                                            Placeholder = "Message:"
                                        },
                                        new Label
                                        {
                                            Text = "Gender:", TextColor = Color.Black
                                        }.Margins(left: 8),
                                        new RadioButton
                                        {
                                            GroupName = "Gender",
                                            Text = "Male",
                                        },
                                        new RadioButton
                                        {
                                            GroupName = "Gender",
                                            Text = "Female",
                                        },
                                        new Button
                                        {
                                            Text = "Send",
                                            HeightRequest = 66,
                                            StyleClass = new string[] {"actionButton" },
                                            CornerRadius = 0,
                                            FontSize = 18

                                        }.Margins(top: 20)

                                    }
                                }
                            }.Row(Row.Content), // Frame
                            new Image
                            {
                                Source = new FontImageSource
                                {
                                    FontFamily = "fa-solid-900.ttf",
                                    Glyph = IconFont.Envelope,
                                    Size = 88,
                                    Color = Color.LightGray
                                }
                            }
                            .Center()
                            .Row(Row.Push)


                }
            };
        } // Build

        enum Row { Title, Content, Push }
    }
}
