using System;
using System.Text;
using System.Runtime.InteropServices;


namespace Reader
/*----------------------------------------------------------------
Copyright (C) 2014 ��ͼ��Ա����ϵͳ��Grant ��������

��Ŀ���ƣ� ��ͼ��Ա����ϵͳ
�����ߣ�   grant (������ emaill : nnn987@126.com ; QQ:406333743;Tel:+86 15619212255)
CLR�汾��  4.0.30319.42000
ʱ�䣺     2014/8/28 18:16:22

���������������Ϊ����ҵ��ʱ����д��������Դ�붼���Խ�����ѵ�ѧϰ����������������ҵ��;

----------------------------------------------------------------*/
{
    /// <summary>
    /// API_RF ��ժҪ˵����
    /// </summary>

    //
    //************************************����RF��д��*************************
    //
    public class API_RF
    {

        [DllImport(@"STReader\iccrf.dll")]
        public static extern int rf_beep(int _Msec);//��д������
        [DllImport(@"STReader\iccrf.dll")]
        public static extern int rf_card(byte _Mode, ref uint snr);//MODE��Ѱ��ģʽ:0һ��ֻ��һ�ſ�����; 1һ�ζԶ��ſ�����
        [DllImport(@"STReader\iccrf.dll")]
        public static extern int rf_halt();//ֹͣ������

    }


}
