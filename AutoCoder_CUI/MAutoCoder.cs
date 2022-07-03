using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MCommandCS;
using AutoCoder;

namespace AutoCoder_CUI
{
    /// <summary>
    /// ���w�R�}���h��񋟂��郂�W���[���N���X
    /// </summary>
    public class MAutoCoder : MModule
    {
        protected AutoCoder.AutoCoder autocoder = new AutoCoder.AutoCoder();
        public MAutoCoder()//~~~~~�R�}���h��`�����番�򏈗���ǉ����鎖~~~~~
        {
            this.ModuleName = "autocoder";
            this.Commands.Add("new");
            this.Commands.Add("load");
            this.Commands.Add("project");
            this.Commands.Add("newnamespace");
            this.Commands.Add("addnmsp");
            this.Commands.Add("nmsp");
            this.Commands.Add("help");
        }

        public override void ExecuteCommand(List<string> args)
        {
            //autocoder.new [name]�@�w�肵�����̂Ńv���W�F�N�g���쐬���܂��B
            if(args[1] == this.Commands[0])
            {
                try
                {
                    this.autocoder.NewProject(args[2]);
                    Console.WriteLine("Created Project: " + this.autocoder.GetProjectName());
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Not enough arg: name");
                    return;
                }
                
            }//autocoder.load�@���ɍ쐬���ꂽ�v���W�F�N�g�����[�h���܂��B
            else if(args[1] == this.Commands[1])
            {

            }//autocoder.project�@�v���W�F�N�g����\�����܂��B
            else if(args[1] == this.Commands[2])
            {
                Console.WriteLine("Project_Name: " + this.autocoder.GetProjectName());
            }//autocoder.newnamespace [name]�@�w�肵�����̂ŐV�K�ɖ��O��Ԃ��쐬���܂��B
            else if(args[1] == this.Commands[3])
            {
                try
                {
                    this.autocoder.NewNamespace(args[2]);
                    Console.WriteLine("Created Namespace: " + this.autocoder.GetNamespaceName());
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Not enough arg: name");
                    return;
                }
            }//autocoder.addnmsp�@���݂̃v���W�F�N�g�Ɍ��݂̖��O��Ԃ�ǉ����܂��B
            else if(args[1] == this.Commands[4])
            {
                this.autocoder.AddNmspToProject();
                Console.WriteLine("Added current namespace to project: " + autocoder.GetNamespaceName());
            }//autocoder.nmsp�@���ݍ쐬���̖��O��Ԃ̖��̂�\�����܂��B
            else if(args[1] == this.Commands[5])
            {
                Console.WriteLine("Namespace_Name: " + this.autocoder.GetNamespaceName());
            }//autocoder.help�@AutoCoder�̃R�}���h�ꗗ��\�������܂��B
            else if(args[1] == this.Commands[6])
            {
                this.ShowHelp();
            }
            //~~~~~����ǉ�������R�}���h�ǉ����鎖~~~~~
        }
    }
}