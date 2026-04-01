using ADDINPRUEBA1.Commands;
using Nice3point.Revit.Toolkit.External;

namespace ADDINPRUEBA1
{
    /// <summary>
    ///     Application entry point
    /// </summary>
    [UsedImplicitly]
    public class Application : ExternalApplication
    {
        public override void OnStartup()
        {
            CreateRibbon();
        }

        private void CreateRibbon()
        {
            var panel = Application.CreatePanel("Commands", "ADDINPRUEBA1");

            panel.AddPushButton<StartupCommand>("Execute")
                .SetImage("/ADDINPRUEBA1;component/Resources/Icons/RibbonIcon16.png")
                .SetLargeImage("/ADDINPRUEBA1;component/Resources/Icons/RibbonIcon32.png");
        }
    }
}