#Classification
dataTrain <- read.csv(file="C:\\Users\\splaza\\Downloads\\data.train.csv",head=TRUE,sep=",")
dataTest <- read.csv(file="C:\\Users\\splaza\\Downloads\\ClassificationResults.csv",head=TRUE,sep=",")

dataTest$Colour="greenyellow"
dataTest$Colour[dataTest$cls<=2]="cyan"
dataTest$Colour[dataTest$cls<=1]="lightpink"
plot(dataTest$x,dataTest$y, col=dataTest$Colour,xlim=c(-1.5,1.5), ylim=c(-1.5,1.5),xlab="X", ylab="Y")

par(new=TRUE)
dataTrain$Colour="green"
dataTrain$Colour[dataTrain$cls<=2]="blue"
dataTrain$Colour[dataTrain$cls<=1]="red"
plot(dataTrain$x,dataTrain$y, col=dataTrain$Colour,xlim=c(-1.5,1.5), ylim=c(-1.5,1.5),xlab="X", ylab="Y")



#Regression
dataTrain <- read.csv(file="C:\\Users\\splaza\\Downloads\\data.xsq.train.csv",head=TRUE,sep=",")
dataTest <- read.csv(file="C:\\Users\\splaza\\Downloads\\RegressionResults.csv",head=TRUE,sep=",")
plot(dataTrain$x,dataTrain$y,xlim=c(-5,7), ylim=c(0,25),xlab="X", ylab="Y")
par(new=TRUE)
plot(dataTest$x,dataTest$y, col="red",xlim=c(-5,7), ylim=c(0,25),xlab="X", ylab="Y")


#Errors
data <- read.csv(file="h:\\Windows7\\Desktop\\NeuralNetworksProject\\Project1\\NeuralNetworks\\bin\\Debug\\TrainingErrors.csv",head=TRUE,sep=",")
plot(data$iterarion,data$error)
