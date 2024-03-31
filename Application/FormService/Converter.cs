using Domian.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Application.FormService
{
    public class Converter
    {
        public static string JsonToHtmlConverter(Form jsonObj, List<FormElement> filter /*Action<StringBuilder, Form> additionalElements*/)
        {
            try
            {
                // Build HTML string
                StringBuilder html = new StringBuilder();
                html.AppendFormat("<div style=\"width: {0}px; height: {1}px; background-color: {2}; color: {3}; margin: {4}px {5}px {6}px {7}px; display: flex; align-items: {8}; justify-content: {9}; flex-wrap: {10}; direction: {11};\">",
                    jsonObj.Style.Width, jsonObj.Style.Height, jsonObj.Style.BackgroundColor, jsonObj.Style.Color,
                    jsonObj.Style.MarginTop, jsonObj.Style.MarginRight, jsonObj.Style.MarginBottom, jsonObj.Style.MarginLeft,
                    jsonObj.Style.AlignItems, jsonObj.Style.Justify, jsonObj.Style.FlexWrap, jsonObj.Style.Direction);
                if (filter != null)
                {


                    // Add filtered form elements
                    foreach (FormElement element in filter)
                    {
                        switch (element.ElementType)
                        {
                            case (Domian.Enums.ElementType)1:
                                html.AppendLine($"<label for=\"{element.Id}\">{element.ElementLabel}</label>");
                                html.AppendLine($"<input type=\"text\" id=\"{element.Id}\" name=\"{element.ElementLabel}\" />");
                                break;
                            case (Domian.Enums.ElementType)2:
                                html.AppendLine($"<label for=\"{element.Id}\">{element.ElementLabel}</label>");
                                html.AppendLine($"<input type=\"number\" id=\"{element.Id}\" name=\"{element.ElementLabel}\" />");
                                break;
                            case (Domian.Enums.ElementType)3:
                                html.AppendLine($"<label for=\"{element.Id}\">{element.ElementLabel}</label>");
                                html.AppendLine($"<input type=\"number\" id=\"{element.Id}\" name=\"{element.ElementLabel}\" />");
                                break;
                            case (Domian.Enums.ElementType)4:
                                html.AppendLine($"<label for=\"{element.Id}\">{element.ElementLabel}</label>");
                                html.AppendLine($"<input type=\"number\" id=\"{element.Id}\" name=\"{element.ElementLabel}\" />");
                                break;
                            case (Domian.Enums.ElementType)5:
                                html.AppendLine($"<label for=\"{element.Id}\">{element.ElementLabel}</label>");
                                html.AppendLine($"<input type=\"number\" id=\"{element.Id}\" name=\"{element.ElementLabel}\" />");
                                break;
                            case (Domian.Enums.ElementType)6:
                                html.AppendLine($"<label for=\"{element.Id}\">{element.ElementLabel}</label>");
                                html.AppendLine($"<input type=\"number\" id=\"{element.Id}\" name=\"{element.ElementLabel}\" />");
                                break;
                            case (Domian.Enums.ElementType)7:
                                html.AppendLine($"<label for=\"{element.Id}\">{element.ElementLabel}</label>");
                                html.AppendLine($"<input type=\"number\" id=\"{element.Id}\" name=\"{element.ElementLabel}\" />");
                                break;
                            case (Domian.Enums.ElementType)8:
                                html.AppendLine($"<label for=\"{element.Id}\">{element.ElementLabel}</label>");
                                html.AppendLine($"<input type=\"number\" id=\"{element.Id}\" name=\"{element.ElementLabel}\" />");
                                break;
                            case (Domian.Enums.ElementType)9:
                                html.AppendLine($"<label for=\"{element.Id}\">{element.ElementLabel}</label>");
                                html.AppendLine($"<input type=\"number\" id=\"{element.Id}\" name=\"{element.ElementLabel}\" />");
                                break;
                            case (Domian.Enums.ElementType)10:
                                html.AppendLine($"<label for=\"{element.Id}\">{element.ElementLabel}</label>");
                                html.AppendLine($"<textarea id=\"{element.Id}\" name=\"{element.ElementLabel}\"></textarea>");
                                break;
                            case (Domian.Enums.ElementType)11:
                                html.AppendLine($"<label for=\"{element.Id}\">{element.ElementLabel}</label>");
                                html.AppendLine($"<input type=\"number\" id=\"{element.Id}\" name=\"{element.ElementLabel}\" />");
                                break;
                            case (Domian.Enums.ElementType)12:
                                html.AppendLine($"<label for=\"{element.Id}\">{element.ElementLabel}</label>");
                                html.AppendLine($"<input type=\"number\" id=\"{element.Id}\" name=\"{element.ElementLabel}\" />");
                                break;
                            case (Domian.Enums.ElementType)13:
                                html.AppendLine($"<label for=\"{element.Id}\">{element.ElementLabel}</label>");
                                html.AppendLine($"<input type=\"number\" id=\"{element.Id}\" name=\"{element.ElementLabel}\" />");
                                break;
                            case (Domian.Enums.ElementType)14:
                                html.AppendLine($"<label for=\"{element.Id}\">{element.ElementLabel}</label>");
                                html.AppendLine($"<input type=\"number\" id=\"{element.Id}\" name=\"{element.ElementLabel}\" />");
                                break;
                            case (Domian.Enums.ElementType)15:
                                html.AppendLine($"<label for=\"{element.Id}\">{element.ElementLabel}</label>");
                                html.AppendLine($"<input type=\"number\" id=\"{element.Id}\" name=\"{element.ElementLabel}\" />");
                                break;
                            case (Domian.Enums.ElementType)16:
                                html.AppendLine($"<label for=\"{element.Id}\">{element.ElementLabel}</label>");
                                html.AppendLine($"<input type=\"number\" id=\"{element.Id}\" name=\"{element.ElementLabel}\" />");
                                break;
                            case (Domian.Enums.ElementType)17:
                                html.AppendLine($"<label for=\"{element.Id}\">{element.ElementLabel}</label>");
                                html.AppendLine($"<input type=\"number\" id=\"{element.Id}\" name=\"{element.ElementLabel}\" />");
                                break;
                            case (Domian.Enums.ElementType)18:
                                html.AppendLine($"<label for=\"{element.Id}\">{element.ElementLabel}</label>");
                                html.AppendLine($"<input type=\"number\" id=\"{element.Id}\" name=\"{element.ElementLabel}\" />");
                                break;
                            case (Domian.Enums.ElementType)19:
                                html.AppendLine($"<label for=\"{element.Id}\">{element.ElementLabel}</label>");
                                html.AppendLine($"<input type=\"number\" id=\"{element.Id}\" name=\"{element.ElementLabel}\" />");
                                break;
                            case (Domian.Enums.ElementType)20:
                                html.AppendLine($"<label for=\"{element.Id}\">{element.ElementLabel}</label>");
                                html.AppendLine($"<input type=\"number\" id=\"{element.Id}\" name=\"{element.ElementLabel}\" />");
                                break;
                            case (Domian.Enums.ElementType)21:
                                html.AppendLine($"<label for=\"{element.Id}\">{element.ElementLabel}</label>");
                                html.AppendLine($"<input type=\"number\" id=\"{element.Id}\" name=\"{element.ElementLabel}\" />");
                                break;
                            case (Domian.Enums.ElementType)22:
                                html.AppendLine($"<label for=\"{element.Id}\">{element.ElementLabel}</label>");
                                html.AppendLine($"<input type=\"number\" id=\"{element.Id}\" name=\"{element.ElementLabel}\" />");
                                break;
                            case (Domian.Enums.ElementType)23:
                                html.AppendLine($"<label for=\"{element.Id}\">{element.ElementLabel}</label>");
                                html.AppendLine($"<input type=\"number\" id=\"{element.Id}\" name=\"{element.ElementLabel}\" />");
                                break;
                            case (Domian.Enums.ElementType)24:
                                html.AppendLine($"<label for=\"{element.Id}\">{element.ElementLabel}</label>");
                                html.AppendLine($"<input type=\"number\" id=\"{element.Id}\" name=\"{element.ElementLabel}\" />");
                                break;
                            case (Domian.Enums.ElementType)25:
                                html.AppendLine($"<label for=\"{element.Id}\">{element.ElementLabel}</label>");
                                html.AppendLine($"<input type=\"number\" id=\"{element.Id}\" name=\"{element.ElementLabel}\" />");
                                break;
                            case (Domian.Enums.ElementType)26:
                                html.AppendLine($"<label for=\"{element.Id}\">{element.ElementLabel}</label>");
                                html.AppendLine($"<input type=\"number\" id=\"{element.Id}\" name=\"{element.ElementLabel}\" />");
                                break;
                            case (Domian.Enums.ElementType)27:
                                html.AppendLine($"<label for=\"{element.Id}\">{element.ElementLabel}</label>");
                                html.AppendLine($"<input type=\"number\" id=\"{element.Id}\" name=\"{element.ElementLabel}\" />");
                                break;
                            case (Domian.Enums.ElementType)28:
                                html.AppendLine($"<label for=\"{element.Id}\">{element.ElementLabel}</label>");

                                break;
                            default:
                                // Handle unknown element types gracefully
                                html.AppendLine($"<p>Unsupported element type: {element.ElementType}</p>");
                                break;
                        }
                    }
                }

                //// Add additional elements
                //additionalElements(html, jsonObj);

                html.AppendLine("</div>");
                return html.ToString();
            }
            catch (Exception ex)
            {
                // Handle JSON deserialization or other errors
                return $"Error converting JSON to HTML: {ex.Message}";
            }
        }

      
    }

}
