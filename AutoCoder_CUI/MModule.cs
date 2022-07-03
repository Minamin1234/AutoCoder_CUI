using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCommandCS
{
    /// <summary>
    /// �R�}���h���W���[�����`����ׂ̊��N���X�D
    /// </summary>
    public class MModule
    {
        /// <summary>
        /// ���W���[���̖��́D�R�}���h�Ń��W���[�����w�肷��ۂ̃L�[���[�h�ɂȂ�܂��D
        /// </summary>
        public string ModuleName = "module";
        /// <summary>
        /// ���W���[�����̃R�}���h�ꗗ
        /// </summary>
        public List<string> Commands = new List<string>();

        public MModule()
        {

        }

        /// <summary>
        /// ���̃��W���[�����Ă΂�C�R�}���h�����s����悤�Ƃ��鎞�D
        /// </summary>
        /// <param name="args">���W���[�����C�R�}���h�C�������܂܂�镶���񃊃X�g</param>
        virtual public void ExecuteCommand(List<string> args)
        {

        }

        /// <summary>
        /// ���̃��W���[���̃R�}���h�ꗗ���o�͂��܂��D
        /// </summary>
        virtual public void ShowHelp()
        {
            Console.WriteLine("----------Commands----------");
            foreach(var cmd in this.Commands)
            {
                Console.WriteLine(this.ModuleName + "." + cmd);
            }
        }
    }
}