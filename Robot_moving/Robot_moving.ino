#include <LCD.h>
#include <LiquidCrystal.h>
#include <LiquidCrystal_I2C.h>
#include <Wire.h>
#include <robot.h>

Robot robot;
int IRR, IRL;

void setup ()
{

}

void loop()
{
  IRL = robot.IR_Read_Left();
  IRR = robot.IR_Read_Right();
  if (IRR == 0 & IRL == 0)
  {
    robot.forward(20);
  }
  else if (IRR == 1 & IRL == 0)
  {
    robot.forwardA(20);
  }
    else if (IRR == 0 & IRL == 1)
    {
      robot.forwardB(20);
    }
    else
    {
      robot.stop();
    }
  }


 
