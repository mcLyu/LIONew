using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterLIO
{
    class ExerciseResultInfo
    {
        public int exerciseId { get; set; }
        public Exercise exercise { get; set; }
        public DateTime dateOfPassing { get; set; }//дата прохождения
        public int errorsCount { get; set; }
        public int assesment { get; set; }//оценка
        public double speed { get; set; }//скорость в буквах в секунду
        public int level { get; set; }
        public int spendetTime { get; set; }//время выполнения в секундах 


        public ExerciseResultInfo(Exercise exercise, DateTime dateOfPassing, int errorsCount, int assesment, double speed, int spendetTime, int level)
        {
            this.exercise = exercise;
            this.exerciseId = exercise.id; 
            this.dateOfPassing = dateOfPassing;
            this.errorsCount = errorsCount;
            this.assesment = assesment;
            this.speed = speed;
            this.level = exercise.level;
            this.spendetTime = spendetTime;
        }

        public ExerciseResultInfo(Exercise exercise, DateTime dateOfPassing, int errorsCount, int assesment, double speed, int spendetTime)
        {
            this.exercise=exercise;
            this.exerciseId = exercise.id; 
            this.dateOfPassing = dateOfPassing;
            this.errorsCount=errorsCount;
            this.assesment = assesment;
            this.speed = speed;
            this.level = exercise.level;
            this.spendetTime = spendetTime;
        }

        public ExerciseResultInfo(int exerciseId, DateTime dateOfPassing, int errorsCount, int assesment, double speed, int spendetTime,int level)
        {
            this.exerciseId = exerciseId;
            this.dateOfPassing = dateOfPassing;
            this.errorsCount = errorsCount;
            this.assesment = assesment;
            this.speed = speed;
            this.level = level;
            this.spendetTime = spendetTime;
        }
    }
}
