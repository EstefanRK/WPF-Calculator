using System.Diagnostics;
using FlaUI.UIA3;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Conditions;

namespace TestProject2
{
    // This class represents a unit test for the HelloWPFApp application.
    [TestClass]
    public class UnitTest1
    {
        // This method tests the functionality of the HelloWPFApp application.
        [TestMethod]
        public void TestMethod1()
        {
            // Launch the HelloWPFApp application.
            var app = FlaUI.Core.Application.Launch("C:\\Users\\estefan.reyeskomaro\\source\\repos\\HelloWPFApp\\HelloWPFApp\\bin\\Debug\\net8.0-windows\\HelloWPFApp.exe");

            // Use the UIA3 automation engine for interacting with the UI elements.
            using (var automation = new UIA3Automation())
            {
                // Get the main window of the application.
                var window = app.GetMainWindow(automation);

                // Create a condition factory using the UIA3 property library.
                ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());

                // Output the title of the main window to the trace.
                Trace.WriteLine(window.Title);

                // Find the button with the text "Click me!" and treat it as a Button element.
                FlaUI.Core.AutomationElements.Button but = window.FindFirstDescendant(cf.ByAutomationId("Button")).AsButton();

                // Find the text box with the automation ID "myTextBox" and treat it as a TextBox element.
                FlaUI.Core.AutomationElements.TextBox tb = window.FindFirstDescendant(cf.ByAutomationId("GoodbyeButton")).AsTextBox();

                // Click the button.
                tb.Click();
                but.Click();

             

                // Find the message box and check its text.
                var messageBox = window.FindFirstChild(cf.ByControlType(FlaUI.Core.Definitions.ControlType.Window));
                Assert.IsNotNull(messageBox, "Message box not found.");

                // Assuming the message box has a text block displaying the message.
                var messageTextBlock = messageBox.FindFirstChild(cf.ByControlType(FlaUI.Core.Definitions.ControlType.Text));
                Assert.IsNotNull(messageTextBlock, "Message text block not found.");

                // Get the text of the message box.
                string messageText = messageTextBlock.Patterns.Value.Pattern.Value.Value;
                Trace.WriteLine($"Message Box Text: {messageText}");

                // Check if the message box contains the expected text.
                Assert.IsTrue(messageText.Contains("Goodbye"), "Unexpected message box content.");
            



            }
        }
    }
}
