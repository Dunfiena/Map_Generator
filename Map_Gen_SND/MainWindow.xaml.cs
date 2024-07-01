using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Map_Gen_SND
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CMD_Handler createNewMap = new CMD_Handler(newMap, true);
            CMD_Handler saveWorkingMap = new CMD_Handler(saveMap, true);
            CMD_Handler exportWorkingMap = new CMD_Handler(exportMap, true);
            CMD_Handler exportWorkingProject = new CMD_Handler(exportProject, true);
            CMD_Handler quitProgram = new CMD_Handler(endRun, true);






            DataContext = new {
                newM = createNewMap,
                save = saveWorkingMap,
                export = exportWorkingMap,
                project = exportWorkingProject,
                quit = quitProgram,
            };

            InputBindings.Add(new KeyBinding(createNewMap, new KeyGesture(Key.N, ModifierKeys.Control)));
            InputBindings.Add(new KeyBinding(saveWorkingMap, new KeyGesture(Key.S, ModifierKeys.Control)));
            InputBindings.Add(new KeyBinding(exportWorkingMap, new KeyGesture(Key.E, ModifierKeys.Control)));
            InputBindings.Add(new KeyBinding(exportWorkingProject, new KeyGesture(Key.D, ModifierKeys.Control)));
            InputBindings.Add(new KeyBinding(quitProgram, new KeyGesture(Key.Q, ModifierKeys.Control)));

        }
        public void newMap() {

        }

        public void saveMap() {

        }

        public void exportMap() {

        }

        public void exportProject() {

        }

        public void endRun() {
            System.Windows.Application.Current.Shutdown();
        }
    }