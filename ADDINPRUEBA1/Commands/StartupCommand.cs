using Autodesk.Revit.Attributes;
using Nice3point.Revit.Toolkit.External;

namespace ADDINPRUEBA1.Commands
{
    /// <summary>
    ///     External command entry point
    /// </summary>
    [UsedImplicitly]
    [Transaction(TransactionMode.Manual)]
    public class StartupCommand : ExternalCommand
    {
        public override void Execute()
        {
        }
    }
}