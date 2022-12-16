using StrategyPattern;

Car lambo = new Lambo();
Car toyota = new ToyotaLancer();

lambo.startDriving();
toyota.startDriving();
lambo.SetDrive(new FullWheelDrive());
toyota.SetDrive(new RearWheelDrive());

lambo.startDriving();
toyota.startDriving();