// Copyright Epic Games, Inc. All Rights Reserved.

#include "NeuralNetworkInterfaceBlueprintBPLibrary.h"
#include "NeuralNetwork.h"
#include "NeuralNetworkInterfaceBlueprint.h"

UNeuralNetworkInterfaceBlueprintBPLibrary::UNeuralNetworkInterfaceBlueprintBPLibrary(const FObjectInitializer& ObjectInitializer)
: Super(ObjectInitializer)
{

}

TArray <float> UNeuralNetworkInterfaceBlueprintBPLibrary::RunNeuralNetworkModel(UNeuralNetwork* Model, ENeuralDeviceType Device,TArray <float> InputData)
{

	Model->SetDeviceType(Device);

	Model->SetInputFromArrayCopy(InputData);

	Model->Run();

	return Model->GetOutputTensor().GetArrayCopy<float>();
}

