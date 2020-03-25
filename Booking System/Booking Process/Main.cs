/***************************************************************
    *  DO NOT EDIT THIS FILE!
    *         
    *  This file is automatically generated by HP Service Test.
    *  Manually changing the contents of this file may result in 
    *  loss of information.
    *          
    *  To edit the test, open the file ‘Booking Process.st’ 
    *  in HP Service Test.
     ***************************************************************/
    
    namespace Script
    {
    using System;
    using System.Text;
    using System.Threading;
    using System.Xml;
    using System.Xml.Schema;
    using HP.ST.Fwk.ReporterFWK;
    using HP.ST.Shared.Utilities;
    using HP.ST.Ext.BindingImpl.Getters;
    using HP.ST.Ext.BindingImpl.Setters;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.PropInfo;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.Getters;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.Setters;
    using HP.ST.Fwk.RunTimeFWK;
    using HP.ST.Fwk.RunTimeFWK.Utilities;
    using HP.ST.Fwk.RunTimeFWK.HelperClasses;
    using HP.ST.Fwk.RunTimeFWK.CompositeActivities;
    using HP.ST.Ext.BindingImpl.Setters.DataSourceSetters;
    using HP.ST.Fwk.JVMLoader;
    using System.IO;
    using System.Collections.Generic;
    using System.Reflection;
    using HP.ST.Fwk.SOAReplayAPI;
    using HP.ST.Fwk.UFTLicensing;
    
    
    
    public partial class WorkFlowScript : STWorkFlowScriptBase
    {    
    	TestUserCode _userCode = null;
    	TestEntities _flow = null;
    	static Reporter reporter;
    	int reportLevelInTree;
        HP.ST.Fwk.ReportCreator.QTPEngine.QTPEngineReportCreator reportCreator;
    	
    	public BindDirection bind_dir5 = null;
        public BindDirection bind_dir6 = null;
        
        public IEnumerable<FeaturesGroup> LicensedFeatures
        {
        
        get
        {
        List<FeaturesGroup> features = new List<FeaturesGroup>();
        FeaturesGroup fg1 = new FeaturesGroup();
            fg1.Add(new LicenseFeature("UnifiedFunctionalTesting","1.0"));
            fg1.Add(new LicenseFeature("UnifiedFunctionalTesting","1.1"));
            fg1.Add(new LicenseFeature("UnifiedFunctionalTesting","1.2"));
            features.Add(fg1);
            FeaturesGroup fg2 = new FeaturesGroup();
            FeaturesGroup fg3 = new FeaturesGroup();
            FeaturesGroup fg4 = new FeaturesGroup();
            FeaturesGroup fg5 = new FeaturesGroup();
            return features;
        
        }
        
        }
        
        public WorkFlowScript()
            : base(VuserClass.CommandLineArguments, new STRunTimeContext(), "test")
        {	
        	UpdateContextWithActionFolder(String.Empty);
        	
        }
        
        public WorkFlowScript(ISTRunTimeContext ctx)
            : base(VuserClass.CommandLineArguments, ctx, "test")
            
        {
        	this._context = ctx;
        	UpdateContextWithActionFolder(String.Empty);
        	UpdateTestSettings(ctx);
        }
        
        internal void InitializeComponent()
        {
        	LoadInput();
        	
        	InitReport();
        	
        	InitializeEncryptionManagerValues();
        
        	_userCode = new TestUserCode();
            _flow = _userCode;
            _flow.Context=this._context;
            
            
        
        	_flow.DataFetchActivity52 = new HP.ST.Ext.BasicActivities.DataFetchActivity(_context,"DataFetchActivity52");
            _flow.StartActivity1 = new HP.ST.Ext.BasicActivities.StartActivity(_context,"StartActivity1");
            _flow.Loop2 = new HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop2Input>(_context,"Loop2",LoopType.For);
            _flow.DataExporterActivity54 = new HP.ST.Ext.BasicActivities.DataExporterActivity(_context,"DataExporterActivity54");
            _flow.DataExporterCloseActivity55 = new HP.ST.Ext.BasicActivities.DataExporterCloseActivity(_context,"DataExporterCloseActivity55");
            _flow.EndActivity3 = new HP.ST.Ext.BasicActivities.EndActivity(_context,"EndActivity3");
            _flow.DataDisconnectActivity53 = new HP.ST.Ext.BasicActivities.DataDisconnectActivity(_context,"DataDisconnectActivity53");
            _flow.Sequence51 = new HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence(_context,"Sequence51");
            _flow.CallQTPTest42 = new HP.ST.Ext.UFTActivity.QtpTestActivity(_context,"CallQTPTest42");
            _flow.IfElse43 = new HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElse<IfElse43Input>(_context,"IfElse43");
            _flow.CallQTPTest49 = new HP.ST.Ext.UFTActivity.QtpTestActivity(_context,"CallQTPTest49");
            _flow.IfElseBranch44 = new HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElseBranch(_context,"IfElseBranch44");
            _flow.IfElseBranch45 = new HP.ST.Fwk.RunTimeFWK.CompositeActivities.IfElseBranch(_context,"IfElseBranch45");
            _flow.CallQTPTest46 = new HP.ST.Ext.UFTActivity.QtpTestActivity(_context,"CallQTPTest46");
            _flow.CallQTPTest47 = new HP.ST.Ext.UFTActivity.QtpTestActivity(_context,"CallQTPTest47");
            _flow.CallQTPTest48 = new HP.ST.Ext.UFTActivity.QtpTestActivity(_context,"CallQTPTest48");
            _flow.ReportMessageActivity50 = new HP.ST.Ext.BasicActivities.ReportMessageActivity(_context,"ReportMessageActivity50");
            _flow.DataFetchActivity52.Comment = @"";
            _flow.DataFetchActivity52.IconPath = @"";
            _flow.DataFetchActivity52.AssemblyPath = @"AddIns\ServiceTest\BaseDataProviders\HP.ST.Ext.CustomDataProviders.dll";
            _flow.DataFetchActivity52.QueryClassName = @"HP.ST.Ext.CustomDataProviders.ExcelFileDataQuery";
            XmlDocument DataFetchActivity52_QueryParameters_Document = new XmlDocument();
            DataFetchActivity52_QueryParameters_Document.PreserveWhitespace = true;
            string xmlDataFetchActivity52Params = @"<Arguments><QueryParametersContainer><QueryParameter><Name>Id</Name><Value>dbe0dc38-230c-49fd-8202-c42587b68af6</Value></QueryParameter><QueryParameter><Name>QueryName</Name><Value>GenerateTestData!Global</Value></QueryParameter><QueryParameter><Name>IsEmbedded</Name><Value>True</Value></QueryParameter><QueryParameter><Name>Externalized</Name><Value>False</Value></QueryParameter><QueryParameter><Name>GroupText</Name><Value>GenerateTestData</Value></QueryParameter><QueryParameter><Name>FilePath</Name><Value>" + _context.ResourceManager.GetValue("{GenerateTestData!Global.TablePath}") + "</Value></QueryParameter><QueryParameter><Name>SheetName</Name><Value>Global$</Value></QueryParameter><QueryParameter><Name>ContainsHeadersRow</Name><Value>True</Value></QueryParameter></QueryParametersContainer></Arguments>";
            DataFetchActivity52_QueryParameters_Document.LoadXml(xmlDataFetchActivity52Params);
            _flow.DataFetchActivity52.QueryParameters = DataFetchActivity52_QueryParameters_Document;
            _flow.dataSourceNameToDataSource.Add("GenerateTestData!Global", _flow.DataFetchActivity52);
            this.Activities.Add (_flow.DataFetchActivity52);
            _flow.StartActivity1.Comment = @"";
            _flow.StartActivity1.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_code_activity.png";
            _flow.StartActivity1.Name = @"Start";
            _flow.StartActivity1.JVM = new HP.ST.Ext.BasicActivities.JVMProperties();
            _flow.StartActivity1.IsJavaUsed = false;
            _flow.StartActivity1.JVM.Classpath = @"%CLASSPATH%";
            _flow.StartActivity1.JVM.AdditionalVMParameters = @"";
            _flow.StartActivity1.JMS = new HP.ST.Ext.BasicActivities.JMSProperties();
            _flow.StartActivity1.IsJmsUsed = false;
            _flow.StartActivity1.JMS.JNDIContextFactory = @"<Select...>";
            _flow.StartActivity1.JMS.JNDIProviderUrl = @"";
            _flow.StartActivity1.JMS.JMSConnectionFactory = @"";
            _flow.StartActivity1.JMS.SecurityPrincipal = @"";
            _flow.StartActivity1.JMS.SecurityCredentials = @"";
            _flow.StartActivity1.JMS.JMSClientID = @"";
            _flow.StartActivity1.JMS.SSLPassword = @"";
            _flow.StartActivity1.JMS.SSLTrustedCertificate = @"";
            _flow.StartActivity1.JMS.SSLIdentity = @"";
            _flow.StartActivity1.JMS.ConnectionsPerProcess = @"1";
            _flow.StartActivity1.JMS.TimeoutOptions = @"DN_User_defined_Timeout";
            _flow.StartActivity1.JMS.UserTimeout = @"20";
            _flow.StartActivity1.JMS.GenerateAutoSelector = @"No";
            this.Activities.Add (_flow.StartActivity1);
            _flow.Loop2.ConditionAsString = @"Run for 1 iteration";
            _flow.Loop2.NumberOfIterations = (int)1;
            _flow.Loop2.Comment = @"";
            _flow.Loop2.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_loop.png";
            _flow.Loop2.Name = @"Test Flow";
            _flow.Loop2.Activities.Add (_flow.Sequence51);
            this.Activities.Add (_flow.Loop2);
            _flow.DataExporterActivity54.Comment = @"";
            _flow.DataExporterActivity54.IconPath = @"";
            VTDPropertyInfoBase pi9 = new VTDPropertyInfoBase("OutTable");
            VTDBaseGetter binding_getter5 = new VTDObjectGetter(pi9);
            VTDPropertyInfoBase pi10 = new VTDPropertyInfoBase("Data");
            VTDBaseSetter binding_setter5 = new VTDObjectSetter(pi10);
            binding_setter5 = new StringFormaterDecorator(binding_setter5,"{Step.DataFetchActivity52.OutTable}");
            bind_dir5 = new BindDirection(_flow.DataFetchActivity52,binding_getter5,binding_setter5,BindTargetType.ToInProperty);
            _flow.DataExporterActivity54.InDirections.Add(bind_dir5);
            this.Activities.Add (_flow.DataExporterActivity54);
            _flow.DataExporterCloseActivity55.Comment = @"";
            _flow.DataExporterCloseActivity55.IconPath = @"";
            this.Activities.Add (_flow.DataExporterCloseActivity55);
            _flow.EndActivity3.Comment = @"";
            _flow.EndActivity3.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_code_activity.png";
            _flow.EndActivity3.Name = @"End";
            this.Activities.Add (_flow.EndActivity3);
            _flow.DataDisconnectActivity53.Comment = @"";
            _flow.DataDisconnectActivity53.IconPath = @"";
            VTDPropertyInfoBase pi11 = new VTDPropertyInfoBase("OutTable");
            VTDBaseGetter binding_getter6 = new VTDObjectGetter(pi11);
            VTDPropertyInfoBase pi12 = new VTDPropertyInfoBase("Data");
            VTDBaseSetter binding_setter6 = new VTDObjectSetter(pi12);
            binding_setter6 = new StringFormaterDecorator(binding_setter6,"{Step.DataFetchActivity52.OutTable}");
            bind_dir6 = new BindDirection(_flow.DataFetchActivity52,binding_getter6,binding_setter6,BindTargetType.ToInProperty);
            _flow.DataDisconnectActivity53.InDirections.Add(bind_dir6);
            this.Activities.Add (_flow.DataDisconnectActivity53);
            _flow.Sequence51.Comment = @"";
            _flow.Sequence51.IconPath = @"";
            _flow.Sequence51.Name = @"Sequence51";
            _flow.Sequence51.Activities.Add (_flow.CallQTPTest42);
            _flow.Sequence51.Activities.Add (_flow.IfElse43);
            _flow.Sequence51.Activities.Add (_flow.CallQTPTest49);
            XmlDocument CallQTPTest42_InputArguments_Document = new XmlDocument();
            CallQTPTest42_InputArguments_Document.PreserveWhitespace = true;
            CallQTPTest42_InputArguments_Document.LoadXml(
@"<Arguments><Agent>John</Agent><Password>5e28a383f272f0458ede</Password></Arguments>");
            _flow.CallQTPTest42.InputArguments = CallQTPTest42_InputArguments_Document;
            _flow.CallQTPTest42.Comment = @"";
            _flow.CallQTPTest42.IconPath = @"AddIns\ServiceTest\UFT\toolbox_qtp.png";
            _flow.CallQTPTest42.Name = @"Create New Order.FR - Login";
            _flow.CallQTPTest42.ScriptPath = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest42.ScriptPath}")) ? @"..\..\demo\Booking System\Create New Order" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest42.ScriptPath}");
            _flow.CallQTPTest42.ActionName = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest42.ActionName}")) ? @"FR - Login" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest42.ActionName}");
            _flow.CallQTPTest42.Description = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest42.Description}")) ? @"" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest42.Description}");
            _flow.CallQTPTest42.IsActionSelected = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest42.IsActionSelected}")) ? @"True" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest42.IsActionSelected}");
            _flow.CallQTPTest42.ResultLocation = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest42.ResultLocation}")) ? @"RunQTPReport\" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest42.ResultLocation}");
            _flow.CallQTPTest42.QCScriptPath = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest42.QCScriptPath}")) ? @"" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest42.QCScriptPath}");
            _flow.IfElse43.ConditionAsString = @"Is False";
            _flow.IfElse43.Comment = @"";
            _flow.IfElse43.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_if_else.png";
            _flow.IfElse43.Name = @"Login successful?";
            _flow.IfElse43.Activities.Add (_flow.IfElseBranch44);
            _flow.IfElse43.Activities.Add (_flow.IfElseBranch45);
            _flow.CallQTPTest49.Comment = @"";
            _flow.CallQTPTest49.IconPath = @"AddIns\ServiceTest\UFT\toolbox_qtp.png";
            _flow.CallQTPTest49.Name = @"Create New Order.FR - Close App";
            _flow.CallQTPTest49.ScriptPath = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest49.ScriptPath}")) ? @"..\..\demo\Booking System\Create New Order" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest49.ScriptPath}");
            _flow.CallQTPTest49.ActionName = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest49.ActionName}")) ? @"FR - Close App" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest49.ActionName}");
            _flow.CallQTPTest49.Description = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest49.Description}")) ? @"" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest49.Description}");
            _flow.CallQTPTest49.IsActionSelected = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest49.IsActionSelected}")) ? @"True" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest49.IsActionSelected}");
            _flow.CallQTPTest49.ResultLocation = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest49.ResultLocation}")) ? @"RunQTPReport\" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest49.ResultLocation}");
            _flow.CallQTPTest49.QCScriptPath = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest49.QCScriptPath}")) ? @"" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest49.QCScriptPath}");
            _flow.IfElseBranch44.Condition += delegate(object sender,EventArgs e)
            {
            return false;
            };
            _flow.IfElseBranch44.Comment = @"";
            _flow.IfElseBranch44.IconPath = @"";
            _flow.IfElseBranch44.Name = @"Yes";
            _flow.IfElseBranch44.Activities.Add (_flow.CallQTPTest46);
            _flow.IfElseBranch44.Activities.Add (_flow.CallQTPTest47);
            _flow.IfElseBranch44.Activities.Add (_flow.CallQTPTest48);
            _flow.IfElseBranch45.Condition += delegate(object sender,EventArgs e)
            {
            return true;
            };
            _flow.IfElseBranch45.Comment = @"";
            _flow.IfElseBranch45.IconPath = @"";
            _flow.IfElseBranch45.Name = @"No";
            _flow.IfElseBranch45.Activities.Add (_flow.ReportMessageActivity50);
            XmlDocument CallQTPTest46_InputArguments_Document = new XmlDocument();
            CallQTPTest46_InputArguments_Document.PreserveWhitespace = true;
            CallQTPTest46_InputArguments_Document.LoadXml(
@"<Arguments><FromCity>Denver</FromCity><ToCity>Frankfurt</ToCity><Date>27/03/2020</Date><Class>Economy</Class></Arguments>");
            _flow.CallQTPTest46.InputArguments = CallQTPTest46_InputArguments_Document;
            _flow.CallQTPTest46.Comment = @"";
            _flow.CallQTPTest46.IconPath = @"AddIns\ServiceTest\UFT\toolbox_qtp.png";
            _flow.CallQTPTest46.Name = @"Create New Order.FR - Find Flight";
            _flow.CallQTPTest46.ScriptPath = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest46.ScriptPath}")) ? @"..\..\demo\Booking System\Create New Order" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest46.ScriptPath}");
            _flow.CallQTPTest46.ActionName = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest46.ActionName}")) ? @"FR - Find Flight" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest46.ActionName}");
            _flow.CallQTPTest46.Description = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest46.Description}")) ? @"" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest46.Description}");
            _flow.CallQTPTest46.IsActionSelected = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest46.IsActionSelected}")) ? @"True" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest46.IsActionSelected}");
            _flow.CallQTPTest46.ResultLocation = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest46.ResultLocation}")) ? @"RunQTPReport\" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest46.ResultLocation}");
            _flow.CallQTPTest46.QCScriptPath = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest46.QCScriptPath}")) ? @"" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest46.QCScriptPath}");
            _flow.CallQTPTest47.Comment = @"";
            _flow.CallQTPTest47.IconPath = @"AddIns\ServiceTest\UFT\toolbox_qtp.png";
            _flow.CallQTPTest47.Name = @"Create New Order.FR - Select Flight";
            _flow.CallQTPTest47.ScriptPath = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest47.ScriptPath}")) ? @"..\..\demo\Booking System\Create New Order" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest47.ScriptPath}");
            _flow.CallQTPTest47.ActionName = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest47.ActionName}")) ? @"FR - Select Flight" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest47.ActionName}");
            _flow.CallQTPTest47.Description = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest47.Description}")) ? @"" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest47.Description}");
            _flow.CallQTPTest47.IsActionSelected = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest47.IsActionSelected}")) ? @"True" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest47.IsActionSelected}");
            _flow.CallQTPTest47.ResultLocation = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest47.ResultLocation}")) ? @"RunQTPReport\" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest47.ResultLocation}");
            _flow.CallQTPTest47.QCScriptPath = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest47.QCScriptPath}")) ? @"" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest47.QCScriptPath}");
            XmlDocument CallQTPTest48_InputArguments_Document = new XmlDocument();
            CallQTPTest48_InputArguments_Document.PreserveWhitespace = true;
            CallQTPTest48_InputArguments_Document.LoadXml(
@"<Arguments><Passenger>Amir Khan</Passenger></Arguments>");
            _flow.CallQTPTest48.InputArguments = CallQTPTest48_InputArguments_Document;
            _flow.CallQTPTest48.Comment = @"";
            _flow.CallQTPTest48.IconPath = @"AddIns\ServiceTest\UFT\toolbox_qtp.png";
            _flow.CallQTPTest48.Name = @"Create New Order.FR - Enter Passenger Details";
            _flow.CallQTPTest48.ScriptPath = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest48.ScriptPath}")) ? @"..\..\demo\Booking System\Create New Order" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest48.ScriptPath}");
            _flow.CallQTPTest48.ActionName = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest48.ActionName}")) ? @"FR - Enter Passenger Details" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest48.ActionName}");
            _flow.CallQTPTest48.Description = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest48.Description}")) ? @"" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest48.Description}");
            _flow.CallQTPTest48.IsActionSelected = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest48.IsActionSelected}")) ? @"True" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest48.IsActionSelected}");
            _flow.CallQTPTest48.ResultLocation = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest48.ResultLocation}")) ? @"RunQTPReport\" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest48.ResultLocation}");
            _flow.CallQTPTest48.QCScriptPath = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest48.QCScriptPath}")) ? @"" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.CallQTPTest48.QCScriptPath}");
            _flow.ReportMessageActivity50.Status = @"Fail";
            _flow.ReportMessageActivity50.Message = @"Login failed";
            _flow.ReportMessageActivity50.Destination = @"ReportAndOutput";
            _flow.ReportMessageActivity50.Comment = @"";
            _flow.ReportMessageActivity50.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_report_message.png";
            _flow.ReportMessageActivity50.Name = @"Login failed";
            
        }
        
        internal void InitializeEncryptionManagerValues()
        {
        
        }
        	
    	bool useReport = true;
    
    	protected override STExecutionResult ExecuteStep()
        {
            return base.ExecuteStep();
        }
    
        public void Start()
        {
    	    try
    		{
    		  Workflow_Executing();
    		  this.ExecuteStep();
    		}
    		finally
    		{
    		  WorkFlowScript_Completed();
    		}
        }
    
    	private void InitReport()
    	{
    		if (useReport)
    		{	
    			// Intialize Reporter
    			string reportDBDir = Path.Combine(this._context.ReportDirectory, @"Report");
    			CleanupReport(reportDBDir);        	
    			string reportDBPath = Path.Combine(reportDBDir, "VTDReport.mdb");        	
    			if (reporter == null)
    			{
    				reporter = new Reporter(reportDBPath);
    			}
    			_context.Reporter = reporter;
    		}
    	}
    
        public static void CopyDirectory(string Src, string Dst)
        {
            String[] Files;
    
            if (Dst[Dst.Length - 1] != Path.DirectorySeparatorChar)
                Dst += Path.DirectorySeparatorChar;
            if (!Directory.Exists(Dst)) Directory.CreateDirectory(Dst);
            Files = Directory.GetFileSystemEntries(Src);
            foreach (string Element in Files)
            {
                // Sub directories
                if (Directory.Exists(Element))
                    CopyDirectory(Element, Dst + Path.GetFileName(Element));
                // Files in directory
                else
                    File.Copy(Element, Dst + Path.GetFileName(Element), true);
            }
        }
        
        private void CleanupReport(string reportDBDir)
        {   
    		if (useReport)
    		{             
    			string reportTemplateDir = Path.Combine(ServiceTestRunner.GetInstallPath(),@"bin\ReportResources");                
    			try
    			{
            		CopyDirectory(reportTemplateDir, reportDBDir);
    			}
    			catch //(Exception ex)
    			{
    				//ToDo: LoggingService.Warn("Report Cleanup Error", ex);
    			}
    		}
        }
    
        void Workflow_Executing()
        {   
        	InitReportNode();
                       
        }
    
    	private void InitReportNode()
    	{
    		if (useReport)
    		{	
        		// Init report creator
    			this.reportCreator = new HP.ST.Fwk.ReportCreator.QTPEngine.QTPEngineReportCreator();
    			this.reportLevelInTree = reportCreator.Init(_context.EnvironmentProfile.GetVariableValue("TestName"), _context);
                
    			STActivityBase activity = this;
    			string workflowID = activity.GetHashCode().ToString();
    			ReportNodeCreationData newNodeData =
    			new ReportNodeCreationData(workflowID, workflowID, DateTime.Now);
    			reporter.CreateReportNode(newNodeData);
            
    			ReportInfoData newReportData = new ReportInfoData(workflowID, ReportKeywords.TypeKeywordTag, this.GetType().ToString());
    			reporter.SendReportData(newReportData);
    			newReportData = new ReportInfoData(workflowID, ReportKeywords.NameKeywordTag, this.Name);
    			//TrackData(ReportInfoData.InfoDataTag, newReportData);
    			reporter.SendReportData(newReportData);            
            }
    	}
        
        void WorkFlowScript_Completed()
        {   
    		
    
    		CreateReportFiles();
    					
        	// Write all snapshots to disk
    		this._context.SnapshotManager.WriteSnapshotsToDisk();
    
    		OnExecutionCompleted();
    		
        }
    
    	private void CreateReportFiles()
    	{
    		if (useReport)
    		{	
    			//Dispose reporter inorder to close connection to report DB
           		this._context.Reporter.Dispose();
            	
           		// Run report creator
    			reportCreator.RunOnDBAndCreateFiles();
    		}
    	}
    
        
        void Workflow_Faulting()
        {
    		
    
    		CreateReportFiles();
            // Write all snapshots to disk
    		this._context.SnapshotManager.WriteSnapshotsToDisk();
           
    		OnExecutionCompleted();
        }
    
    	protected override QcSystemVariables GetRuntimeQcVariables(ISTRunTimeContext context)
    	{
    		return new HP.ST.Ext.BasicActivities.RuntimeQcVariables(this._context);
    	}
            
    	protected override TestSystemVariables GetTestSystemVariables(ISTRunTimeContext context)
    	{
    		return new HP.ST.Ext.BasicActivities.RuntimeTestVariables(this._context);
    	}
    
    	private void UpdateTestSettings(ISTRunTimeContext ctx)
        {
    		ctx.PropertyBag["StopTestOnStepFailure"] = true;
    	}
    }
    
    public partial class VuserClass
    {
    	public static string[] CommandLineArguments;
    	public static string[] DotNetResolverPaths;
    	
        public VuserClass()
        {
    				
    		AssemblyResolver.AddSTPathsToResolutionPaths();
    		AssemblyResolver.AttachToAppdomain();
        }
    
        private void AddAssemblyResolver()
        {
    		AssemblyResolver.AddTestPathToResolutionPaths(GetTestPath());
    		AssemblyResolver.AddPathsForAssemblyResolution(DotNetResolverPaths);
        }
    	
        public int STAction()
        {	
            AddAssemblyResolver();
            STRunTimeContext ctx = new STRunTimeContext(Directory.GetParent(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).FullName, string.Empty);
            WorkFlowScript script = new WorkFlowScript(ctx);
            script.InitializeComponent();
            script.Start();       
            
            return 0;
        }
        
        public void NotifyLicenseException(string msg)
        {
        		
    		try
    		{
    		    STRunTimeContext ctx = new STRunTimeContext(Directory.GetParent(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).FullName, string.Empty);
                WorkFlowScript script = new WorkFlowScript(ctx);
                script.InitializeComponent();
                script.Context.ReplayClient.OnLicenseFailure(msg);
                
            }
            catch (Exception)
            {
    			// ToDo: log the error message
            }        
        }
    
    	 protected string GetTestPath()
            {
                if (CommandLineArguments != null)
                {
                    for (int i = 0; i < CommandLineArguments.Length; i++)
                    {
                        if (CommandLineArguments[i].Equals("-test", StringComparison.OrdinalIgnoreCase))
                        {
                            return CommandLineArguments[i + 1];
                        }
                    }
                }
                return String.Empty;
            }
        
    }
    
    }
    