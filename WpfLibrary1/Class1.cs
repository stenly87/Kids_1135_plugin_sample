using Kids1135PluginBase;
using System;
using System.Windows.Controls;

namespace WpfLibrary1
{
    public class Test : IPlugin
    {
        public string Name => "��������� �������";

        public string Description => "��� ������ �������";

        public string Author => "���� ������";

        public Page GetPage()
        {
            return new Page1();
        }
    }


}
