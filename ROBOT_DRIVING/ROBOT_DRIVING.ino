

#include <Wire.h>

#include <robot.h>

#include <Ultrasonic.h>

#include <FastIO.h>
#include <I2CIO.h>
#include <LCD.h>
#include <LiquidCrystal.h>
#include <LiquidCrystal_I2C.h>
#include <LiquidCrystal_SR.h>
#include <LiquidCrystal_SR2W.h>
#include <LiquidCrystal_SR3W.h>

Robot robot;
Ultrasonic ultrasonic(12, 13);
int IRL, IRR;
void setup() {
  // put your setup code here, to run once:

}

void loop() {
  // put your main code here, to run repeatedly:
  IRL = robot.IR_Read_Left();
  IRR = robot.IR_Read_Right();
  if ( IRL == 1 && IRR == 1)
    robot.forward(1);
}
