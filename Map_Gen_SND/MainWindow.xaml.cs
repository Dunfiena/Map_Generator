using System.Text;
using System.Windows;
using System.Windows.Automation.Text;
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
        main_menu_funcs mmfun = new main_menu_funcs();
        style_menu_funcs smfun = new style_menu_funcs();
        generation_menu_funcs gmfun = new generation_menu_funcs();
        project_menu_funcs pmfun = new project_menu_funcs();

        public MainWindow()
        {
            InitializeComponent();
            //Main menu cmd_handlers
            CMD_Handler createNewMap = new CMD_Handler(mmfun.newMap, true);
            CMD_Handler saveWorkingMap = new CMD_Handler(mmfun.saveMap, true);
            CMD_Handler exportWorkingMap = new CMD_Handler(mmfun.exportMap, true);
            CMD_Handler exportWorkingProject = new CMD_Handler(mmfun.exportProject, true);
            CMD_Handler quitProgram = new CMD_Handler(mmfun.endRun, true);

            //Style menu cmd_handlers
            CMD_Handler importAsset = new CMD_Handler(smfun.import_Asset, true);
            CMD_Handler importColor = new CMD_Handler(smfun.import_Color_Palette, true);
            CMD_Handler MapStyle = new CMD_Handler(smfun.set_Map_Style, true);

            //Generation menu cmd_handlers
            CMD_Handler randomize = new CMD_Handler(gmfun.random_Map, true);
            CMD_Handler style_randomized = new CMD_Handler(gmfun.random_Styled_Map, true);
            CMD_Handler auto_fill_map = new CMD_Handler(gmfun.auto_Fill, true);

            //Project menu cmd_handlers
            CMD_Handler create_world = new CMD_Handler(pmfun.create_World, true);
            CMD_Handler update_world = new CMD_Handler(pmfun.update_World, true);
            CMD_Handler upload_map = new CMD_Handler(pmfun.upload_Map, true);


            DataContext = new
            {
                //Main menu Data Context
                newM = createNewMap,
                save = saveWorkingMap,
                export = exportWorkingMap,
                project = exportWorkingProject,
                quit = quitProgram,

                //Style menu Data Context
                importA = importAsset,
                importP = importColor,
                mapStyle = MapStyle,

                //Generation menu Data Context
                random = randomize,
                randomStyled = style_randomized,
                fillMap = auto_fill_map,

                //Project menu Data Context
                createWorld = create_world,
                updateWorld = update_world,
                importM = upload_map
            };

            //Main menu Input Bindings
            InputBindings.Add(new KeyBinding(createNewMap, new KeyGesture(Key.N, ModifierKeys.Control)));
            InputBindings.Add(new KeyBinding(saveWorkingMap, new KeyGesture(Key.S, ModifierKeys.Control)));
            InputBindings.Add(new KeyBinding(exportWorkingMap, new KeyGesture(Key.E, ModifierKeys.Control)));
            InputBindings.Add(new KeyBinding(exportWorkingProject, new KeyGesture(Key.D, ModifierKeys.Control)));
            InputBindings.Add(new KeyBinding(quitProgram, new KeyGesture(Key.Q, ModifierKeys.Control)));

            //Style menu Input Bindings
            InputBindings.Add(new KeyBinding(importAsset, new KeyGesture(Key.I, ModifierKeys.Control)));
            InputBindings.Add(new KeyBinding(importColor, new KeyGesture(Key.O, ModifierKeys.Control)));
            InputBindings.Add(new KeyBinding(MapStyle, new KeyGesture(Key.P, ModifierKeys.Control)));

            //Generation menu Input Bindings
            InputBindings.Add(new KeyBinding(randomize, new KeyGesture(Key.R, ModifierKeys.Control)));
            InputBindings.Add(new KeyBinding(style_randomized, new KeyGesture(Key.T, ModifierKeys.Control)));
            InputBindings.Add(new KeyBinding(auto_fill_map, new KeyGesture(Key.Y, ModifierKeys.Control)));

            //Project menu Input Bindings


        }

    }
}