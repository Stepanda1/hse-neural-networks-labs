using System;
using System.IO;
using System.Reflection;
class PortableLocaleHost {
 [STAThread] static int Main(string[] args) {
  try {
   string root=Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
   Environment.CurrentDirectory=root;
   Assembly.LoadFrom(Path.Combine(root,"LECommonLibrary.dll"));
   Type t=Assembly.LoadFrom(Path.Combine(root,"LEProc.exe")).GetType("LEProc.LoaderWrapper",true);
   object o=Activator.CreateInstance(t,true);
   BindingFlags flags=BindingFlags.Instance|BindingFlags.Public|BindingFlags.NonPublic;
   string app=Path.GetFullPath(args[0]);
   string[] names={"ApplicationName","CommandLine","CurrentDirectory","AnsiCodePage","OemCodePage","LocaleID","DefaultCharset","Timezone","DebugMode"};
   object[] values={app,"\""+app+"\"",Path.GetDirectoryName(app),(uint)1251,(uint)866,(uint)1049,(uint)204,"Ekaterinburg Standard Time",false};
   for(int i=0;i<names.Length;i++)t.GetProperty(names[i],flags).SetValue(o,values[i],null);
   uint ret=(uint)t.GetMethod("Start",flags).Invoke(o,new object[0]);
   Console.WriteLine("Native locale launch result: 0x"+ret.ToString("X8"));return unchecked((int)ret);
  } catch(Exception ex) { Console.Error.WriteLine(ex);return 1; }
 }
}
