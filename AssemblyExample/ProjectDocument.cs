using System;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;

namespace AssemblyExample
{
    class ProjectDocument
    {
        // номинальный момет
        public int nominalTorque;
        // количество пальцев
        public int countFingers;
        // расчитанный диаметр. Обновляется при вызове UpdateParams
        public double nominalDiameter;
        public double calculatedDiameter;

        // папка с муфтой
        public const string workPath = "./Resources/";
        // имя сборки муфты
        public const string asmName = "муфта.SLDASM";

        // имя документа пальца
        public const string fingerName = "Палец.SLDPRT";
        // имя документа полумуфты. Полумуфта использует 2 конфигурации: левая и правая
        // отличие: ширина и вырез под палец
        public const string polumuftaName = "Полумуфта.SLDPRT";

        // Объект Solidworks
        private SldWorks swApp;
        // Документ сборки муфты
        private ModelDoc2 swModel;
        private AssemblyDoc assembly;

        // путь к модели муфты, нужен для выбора ее
        public string assemblyPath;

        public ProjectDocument()
        {
            
        }

        public void InitAndRunSwApp()
        {
            // инициализация объекта приложения Solidworks
            swApp = new SldWorks();
            int error = 0;
            int warning = 0;
            // открытие документа сборки муфты
            // для локальной сборки
            // assemblyPath = ProjectDocument.workPath + ProjectDocument.asmName;

            swModel = swApp.OpenDoc6(assemblyPath, (int)swDocumentTypes_e.swDocASSEMBLY, 0, "", ref error, ref warning);
            assembly = swModel as AssemblyDoc;
            IModelView myModelView = swModel.ActiveView;
            myModelView.FrameState = (int)swWindowState_e.swWindowMaximized;
        }

        // Строит или изменяет модель
        public void Build()
        {
            InitAndRunSwApp();
            // имена размеров в документе полумуфты
            string fingerParameter1 = "fingers@Круговой массив1";
            string fingerParameter2 = "fingers@Круговой массив2";
            string nomianalDiameterParameter = "nominalDiameter@Эскиз1";

            // имя полумуфты в сборке (имя компонента верхнего уровня)
            string assemblyPolumuftaName = "Полумуфта-1";
            // Менеджер выделения, выбора
            SelectionMgr swSelMgr = (SelectionMgr)swModel.SelectionManager;
            // удалить выделение
            swModel.ClearSelection2(true);
            Component2 swComp = assembly.GetComponentByName(assemblyPolumuftaName);
            // выбрать полумуфту, не добавлять к выбранным, дата?, показать всплывающее кокшко
            swComp.Select4(false, null, false);
            int info = 0;
            // начать изменение полумуфты
            assembly.EditPart2(false, false, ref info);
            // получить редактируемую модель
            ModelDoc2 polumufta = (ModelDoc2)assembly.GetEditTarget();
            // установка изменяемых параметров для всех конфигураций
            polumufta.Parameter(fingerParameter1).SetSystemValue3(
                countFingers,
                (int)swSetValueInConfiguration_e.swSetValue_InAllConfigurations
                );
            polumufta.Parameter(fingerParameter2).SetSystemValue3(
                countFingers,
                (int)swSetValueInConfiguration_e.swSetValue_InAllConfigurations
                );

            polumufta.Parameter(nomianalDiameterParameter).SetSystemValue3(
                nominalDiameter, 
                (int)swSetValueInConfiguration_e.swSetValue_InAllConfigurations
                );
            // ??
            bool retVal = polumufta.EditSuppress2();
            //Debug.Assert(retVal);
            // ??
            assembly.EditAssembly();
            swModel.EditRebuild3();
            swModel.ForceRebuild3(false);
            swModel.ViewZoomtofit2();
            
            
        }

        public void CreateSheet()
        {

        }

        //  перерасчет диаметра
        public void UpdateParams()
        {
            double sqrtValue = nominalTorque * 1000.0 * 16.0 / (Math.PI * 80);
            calculatedDiameter = Math.Pow(sqrtValue, 1.0 / 3.0) / 1000.0;
            nominalDiameter = VSTVUtils.NormalizeNumber(calculatedDiameter, 20, 2);
        }
    }
}
