import React, {Component} from "react";
import { View, Text } from "react-native";
import Estilo from '../css/index';


class Lojas extends Component{
    render(){
        return(
            <View>
                <Text style={Estilo.textoTela}>{this.props.Lojas}</Text>
            </View>
        )
    }
}

export default Lojas;