%group = [FineGaus1, FineGaus2, linearSVM];

% yfit = trainedModel.predictFcn(Inputs202106);



% yfit = trainedModel0.predictFcn(Inputs202011);
% 
% yfit = trainedModel.predictFcn(Inputs202102);
% 
% yfit = trainedModel.predictFcn(Inputs202103);

SVMModel{1} = trainedModel;
SVMModel{2} = trainedModel1;
SVMModel{3} = trainedModel2;
SVMModel{4} = trainedModel3;
SVMModel{5} = trainedModel4;
SVMModel{6} = trainedModel5;
SVMModel{7} = trainedModel6;
SVMModel{8} = trainedModel7;
SVMModel{9} = trainedModel8;
SVMModel{10} = trainedModel9;
SVMModel{11} = trainedModel10;
SVMModel{12} = trainedModel11;
SVMModel{13} = trainedModel12;
SVMModel{14} = trainedModel13;
SVMModel{15} = trainedModel14;
SVMModel{16} = trainedModel15;
SVMModel{17} = trainedModel16;
SVMModel{18} = trainedModel17;
SVMModel{19} = trainedModel18;
SVMModel{20} = trainedModel19;
SVMModel{21} = trainedModel20;
SVMModel{22} = trainedModel21;



% InputsList{1} = Inputs202105;
% InputsList{2} = Inputs202106;
% InputsList{1} = Inputs202011;

clear InputsList;
InputsList{1} = Inputs202102;
InputsList{2} = Inputs202103;
InputsList{3} = Inputs202104;
InputsList{4} = Inputs202105;
InputsList{5} = Inputs202106;
InputsList{6} = Inputs202107;
% InputsList{7} = Inputs202011;
% InputsList{8} = Inputs202012;
% InputsList{9} = Inputs202101;


TotalPts = 0;
QtdCompras =0;
ControleCompras =0;
ControleTotalPts = 0;


CompletoTotalPts = 0;
CompletoQtdCompras =0;
CompletoControleCompras =0;
CompletoControleTotalPts = 0;


for i=1:size(SVMModel,2)
    
    for iInpts=1:size(InputsList,2)
        
%          yfit = predict(SVMModel{i}, InputsList{iInpts}(:,2:701) );

         yfit = SVMModel{i}.predictFcn( InputsList{iInpts}(:,2:701) );
         yfit = yfit(:);
         yreal = table2array(InputsList{iInpts}(:,1:1));

         for ifit=1:size(yfit,1)
                ControleCompras =ControleCompras + 1;
                ControleTotalPts = ControleTotalPts + yreal(ifit);
                if  yfit(ifit) > 0
                  QtdCompras = QtdCompras + 1;
                  TotalPts = TotalPts + yreal(ifit);
                end
         end

         disp('Quantidade de trades antes classificador:')
         disp(ControleCompras)
         disp('Quantidade de trades pos classificador:')
         disp(QtdCompras)
         disp('Pts/Trade antes classificador:')
         disp(ControleTotalPts/ControleCompras);
         disp('Pts/Trade pos classificador:')
         disp(TotalPts/QtdCompras);
         disp('Pts/Trade melhora classificador:')
         disp(TotalPts/QtdCompras - ControleTotalPts/ControleCompras);
         disp('___________________')

         CompletoTotalPts = CompletoTotalPts + TotalPts;
         CompletoQtdCompras = CompletoQtdCompras + QtdCompras;
         CompletoControleCompras = CompletoControleCompras + ControleCompras;
         CompletoControleTotalPts = CompletoControleTotalPts + ControleTotalPts;
         
         QtdCompras =0;
         TotalPts = 0;
         ControleCompras =0;
         ControleAcertos =0;
         ControleTotalPts = 0;
    end
    
disp('Quantidade de trades antes classificador:')
disp(CompletoControleCompras)
disp('Quantidade de trades pos classificador:')
disp(CompletoQtdCompras)
disp('Pts/Trade antes classificador:')
disp(CompletoControleTotalPts/CompletoControleCompras);
disp('Pts/Trade pos classificador:')
disp(CompletoTotalPts/CompletoQtdCompras);
disp('Melhora em todos os periodos:')
disp(CompletoTotalPts/CompletoQtdCompras - CompletoControleTotalPts/CompletoControleCompras);
disp('############################')

CompletoTotalPts = 0;
CompletoQtdCompras =0;
CompletoControleCompras =0;
CompletoControleTotalPts = 0;

end



