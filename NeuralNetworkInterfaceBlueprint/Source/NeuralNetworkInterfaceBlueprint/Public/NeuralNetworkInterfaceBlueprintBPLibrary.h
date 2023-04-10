// Copyright Epic Games, Inc. All Rights Reserved.

#pragma once

#include "Kismet/BlueprintFunctionLibrary.h"
#include "NeuralNetwork.h"
#include "NeuralNetworkInterfaceBlueprintBPLibrary.generated.h"

UCLASS()
class UNeuralNetworkInterfaceBlueprintBPLibrary : public UBlueprintFunctionLibrary
{
	GENERATED_UCLASS_BODY()	

	UFUNCTION(BlueprintCallable, meta = (DisplayName = "Run Neural Netowrk Model", Keywords = "NeuralNetwork Blueprint Run"), Category = "NeuralNetworkInterface")
	static TArray <float> RunNeuralNetworkModel(UNeuralNetwork* Model, ENeuralDeviceType Device, TArray <float> InputData);
};
