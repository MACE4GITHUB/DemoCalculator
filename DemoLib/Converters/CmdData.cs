using DemoLib.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DemoLib.Converters
{
    public class CmdData : IDataConverter<Data>
    {
        #region Private
        private string[] _inputParsedData;
        private Data _data;
        private string _dataString; 
        #endregion
        public string InputData { get; private set; }
        public Data GetData(string inputData)
        {
            InputData = inputData;
            _inputParsedData = GetAllPartsData();
            _dataString = string.Join(" ", _inputParsedData);
            _data = GetData();
            return _data;
        }
        public string GetString()
        {
            return _dataString;
        }
        private string[] GetAllPartsData()
        {
            string inputData = InputData.Replace(".", ",").ToLowerInvariant();
            inputData = Regex.Replace(inputData, " {2,}", " ");
            inputData = inputData.Trim();
            string[] data = inputData.Split(' ');
            return data;
        }
        private Data GetData()
        {            
            if (_inputParsedData.Length > 3 || _inputParsedData.Length < 2)
                throw new ArgumentException("Ошибка. Неверное число аргументов. Не соблюдается формат: X operation Y или operation X.");
            if (_inputParsedData.Length == 3)
            {
                if (!double.TryParse(_inputParsedData[0], out double x))
                {
                    x = double.NaN;
                }
                if (!double.TryParse(_inputParsedData[2], out double y))
                {
                    y = double.NaN;
                }
                string operation = _inputParsedData[1];
                return new Data(x, y, operation);
            }
            else
            {
                if (!double.TryParse(_inputParsedData[1], out double x))
                {
                    x = double.NaN;
                }
                string operation = _inputParsedData[0];
                return new Data(x, double.NaN, operation);
            }
        }       
    }
}
