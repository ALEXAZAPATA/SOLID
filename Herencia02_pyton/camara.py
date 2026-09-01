from Dispositivos import DispositivosElectronico
from mixins import conexionWifi, BateriaCargable, SensorMovimineto

class CamaraSeguridadInalambrica(DispositivosElectronico, conexionWifi, BateriaCargable, SensorMovimineto):
    def __init__(self, marca, modelo):
       DispositivosElectronico.__init__(self,marca,modelo)
       conexionWifi.__init__(self)
       BateriaCargable.__init__(self, nivel_bateria = 100)

    def reporte_completo(self):
        texto = f"--- (self, marca) (self.modelo) ---\n"
        texto += f"estado actual: {'Encendida' if self.estado else 'Apagada'}\n"

        if self.red_conectada:
            texto += f"red: conectada a '(self.red_conectada)'\n IP:(self.ip)\n"
        else:
             texto += "red: desconectado\n"

             texto += f"Bateria: (self.nivel_bateria)%"
             if self.nivel_bateria == 0:
                 texto += "[NECESITA CARGA]"
             return texto
