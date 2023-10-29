using EPiServer.Forms.Core.Events;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using System.Collections.Specialized;

namespace EmptyCMS1.Business.InitializationModules
{
    [InitializableModule]
    public class Initialization : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            var events = ServiceLocator.Current.GetInstance<IContentEvents>();

            events.PublishedContent += Events_PublishedContent;
            events.CreatedContent += Events_CreatedContent;

            FormsEvents.Instance.FormsSubmitting += Instance_FormsSubmitting;
        }

        public void Uninitialize(InitializationEngine context)
        {
            var events = ServiceLocator.Current.GetInstance<IContentEvents>();

            events.PublishedContent -= Events_PublishedContent;
            events.CreatedContent -= Events_CreatedContent;

            FormsEvents.Instance.FormsSubmitting -= Instance_FormsSubmitting;
        }

        private void Events_CreatedContent(object? sender, ContentEventArgs e)
        {
            var content = e.Content;

            if (content != null)
            {
                var logText = $"Content {content.Name} created at {DateTime.Now}";
                LogEvent(logText);
            }
        }

        private void Events_PublishedContent(object? sender, ContentEventArgs e)
        {
            var content = e.Content;

            if (content != null)
            {
                var logText = $"Content {content.Name} published at {DateTime.Now}";
                LogEvent(logText);
            }
        }

        private void Instance_FormsSubmitting(object sender, FormsEventArgs e)
        {
            NameValueCollection formData = (NameValueCollection)e.Data;

            if (formData != null)
            {
                var logText = $"Form submitted at {DateTime.Now}";
                LogEvent(logText);

                var items = formData.AllKeys.SelectMany(formData.GetValues, (k, v) => new { key = k, value = v });
                foreach (var item in items)
                {
                    logText = $"{item.key}: {item.value}";
                    LogEvent(logText);
                }
            }
        }

        private void LogEvent(string text)
        {
            using (StreamWriter writer = File.AppendText("EventsLog.txt"))
            {
                writer.WriteLine(text);
            }
        }
    }
}
