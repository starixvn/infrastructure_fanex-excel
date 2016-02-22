// -----------------------------------------------------------------------
// <copyright file="JsonNetResult.cs" company="Nexcel Solutions Vietnam">
// Copyright (c) Nexcel Solutions Vietnam. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

namespace Fanex.Excel.Documentation.Extensions
{
    using System;
    using System.Text;
    using System.Web.Mvc;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// JSON Net Result.
    /// </summary>
    public class JsonNetResult : ActionResult
    {
        public JsonNetResult()
        {
            SerializerSettings = new JsonSerializerSettings();
            SerializerSettings.Converters.Add(new IsoDateTimeConverter());
            Formatting = Formatting.None;
        }

        public JsonNetResult(object data)
            : this()
        {
            Data = data;
        }

        public Encoding ContentEncoding { get; set; }

        public string ContentType { get; set; }

        public object Data { get; set; }

        public JsonSerializerSettings SerializerSettings { get; set; }

        public Formatting Formatting { get; set; }

        /// <summary>
        /// Enables processing of the result of an action method by a custom type that inherits from the <see cref="T:System.Web.Mvc.ActionResult" /> class.
        /// </summary>
        /// <param name="context">
        /// The context in which the result is executed. The context information includes the controller, HTTP content, request context, and route data.
        /// </param>
        /// <exception cref="System.ArgumentNullException">Controller context.</exception>
        public override void ExecuteResult(ControllerContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            var response = context.HttpContext.Response;
            response.ContentType = !string.IsNullOrEmpty(ContentType) ? ContentType : "application/json";
            if (ContentEncoding != null)
            {
                response.ContentEncoding = ContentEncoding;
            }

            if (Data == null)
            {
                return;
            }

            var writer = new JsonTextWriter(response.Output) { Formatting = Formatting };
            var serializer = JsonSerializer.Create(SerializerSettings);
            serializer.Serialize(writer, Data);
            writer.Flush();
        }
    }
}
