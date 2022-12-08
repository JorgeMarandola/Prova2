import { StatusBar } from "expo-status-bar";
import React from "react";
import { Text, View, TouchableOpacity } from "react-native";

import Estilo from './src/css/index'
import api from './src/services/api';

export default function App(){

  
  async function consulta(){
    try{
      const response = await api.get('loja');
      console.log(response);
    }catch{
      console.log(error);
    }
    
  }
  
  return(
    <View style={Estilo.container}>
      <StatusBar style="auto" />
      <TouchableOpacity onPress={consulta}>
        <Text style={Estilo.textoTela}>Consultar</Text>
      </TouchableOpacity>
    </View>
  )
}