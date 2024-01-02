using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_task.Shared.Shared
{
    public class DiabetesPredictionService
    {
        public bool PredictDiabetes(DiabetesInput input)
        {
            // Perform prediction logic here (replace with a real ML model)
            // For simplicity, assume someone with BMI > 30 is predicted to have diabetes
            return input.BMI > 30;
        }
    }

}
