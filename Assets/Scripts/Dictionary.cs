using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// ��ġ, ������, �����, ����, ���, ���ٸ�, ���վ�, �ξ�, ������, ����, �νø�, ����, �췰, �ӿ���, ����, �в�ġ
public class Dictionary : MonoBehaviour
{
    public GameObject canvasMenu, canvasDict;
    public Scrollbar _scrollbar;

    public Image image;
    public Sprite[] fishes;
    public Text[] texts;


    public void Button_galchi()
    {
        canvasMenu.SetActive(false);
        canvasDict.SetActive(true);
        _scrollbar.value = 1;

        image.sprite = fishes[0];

        texts[0].text = $"��ġ";
        texts[1].text = $"50 ~ 100cm";
        texts[2].text = $"7��";
        texts[3].text = $"�׹��� 18cm";
        texts[4].text = $"�ַ� 50~300m ������ ���� �ٴ� �ӿ��� ������, ������ ����� ���ȿ��� �߰ߵǱ⵵ �Ѵ�. �츮���� ��ó������ 2~3�� �� ���ֵ� ���� �ٴٿ��� �ܿ��� �����ٰ�, 4�� �� �������� ������ ���� �̵��Ͽ�, �������� ���ؿ� ����, �߱� ��ó�� ���ȿ� �ӹ����� ���� ���� �����Ѵ�.";
        texts[5].text = $"�õ� ��ġ�� ���� ����ϸ�, ������ ũ��� ��� ���� �ߵ� �츸�� �߶� �ٴÿ� �ܴ�. ��ġ �̿ܿ��� ���� ��ġ �� ���� ���� ��� ���� ���� ��� ����ص� ����. �մ԰���� ���� ��ġ, �����, ������ ���� ����ϴ� ��쵵 �ִ�.";
        texts[6].text = $"�ٴ��� ������ �ö󰡴� 6���� �������� ������ ���� ���� ����ö�� ��ũ�� ������ 12������ �̾�����. ���� �ʹ��� ���Ÿ��� ���ֵ� �ֺ��� ����Ʈ�� �ǰ� ������ ����Կ� ���� ���� ����Ʈ�� �ϻ��� ��â ������ 9�� ���Ŀ��� ���ؾ� ���ȿ� ����Ʈ�� �����ȴ�.";
        texts[7].text = $"- 50~300m�� ���� �ٴٿ��� ��� ��ġ�� �������� ����� ���÷� ���� ���� �Ұ��ɿ� ������. ���� ���� ���ø� �ϸ� ������ �Ǵ��̳� �Ž���⸦ ���� ����Ʈ�� ã�´�.";
        texts[8].text = $"���� ����";
        texts[9].text = $"�̳��� �Ӹ������� ���� �������� ���ùٴ��� ������ �ȴ�. ��ġ�� ������ �۴ٰ� �������ٸ� ��ġ�� ��� �մ����� ���� ���� ������ �Ǵ� ���� ������ ��ġ�� ��� ����ϴ� �͵� ����.";
        texts[10].text = $"���̿� �, �� �� �پ��� ���·� ���� �� �ִ� ������ ��ġ�� ���� ���� ���絵 ����. �¸��� ������� ���� ���� ���� ���� �ִµ� ��ȭ�� �ȵǰ� ���簡ġ�� �����Ƿ� ���� �� ��������.";
    }

    public void Button_gamsungdom()
    {
        canvasMenu.SetActive(false);
        canvasDict.SetActive(true);
        _scrollbar.value = 1;

        image.sprite = fishes[1];

        texts[0].text = $"������";
        texts[1].text = $"30 ~ 50cm";
        texts[2].text = $"5��";
        texts[3].text = $"25cm ����";
        texts[4].text = $"�ٴڿ� �������� �ְ� �����̳� ���ʷ� �� ���� 50m �̳��� ���ȿ� �ַ� �����Ѵ�. �ٴ幰�� �ι��� ���� �ִ� ����� ��� �߰ߵǱ⵵ �ϸ�, � ����� ������ ���� ���� �ִ� ������ ����. �����Ͽ� ��Ȱ�ϱ⵵ �ϰ�, ������ ���� �̵��ϴ� ������ ������ ū �̵��� ������, �ܿ�ö�� ���� ������ �̵��Ѵ�.";
        texts[5].text = $"�������� ��ļ����� ������, �������� ���� �ַ� ������, �̳��δ� �����̸� �ַ� ����Ѵ�.";
        texts[6].text = $"���ؾȿ��� �ַ� ������, ���ؾ�, ���ؾ� ���� ������. ���������ô� ���� ����������, 5~6�� ����� ����, 7~8���� ������ ũ�Ⱑ �۾��� �� 9~10������ �������� ������ ���۵Ǹ�, 11~12���� ��ũ�����̴�.";
        texts[7].text = $"- ������ ��ó ���� 10~30m ������ ���� �ϸ��� ������ ��� ��Ҵ� �������� ü���� �����ϸ� �� �� �����Ƿ� ���� ����Ʈ�� �ȴ�.\n- ����ó ������ ���� ���̰� ǳ���ϰ� ���� ������ �������� �������� ���� ����Ʈ�� �ȴ�.\n- ��, ȫ��, �۰� ���� ����� �ֺ��� �������� ������ ����ó�� ���� ����Ʈ�� �ȴ�.";
        texts[8].text = $"���Ÿ� ��ô\n����";
        texts[9].text = $"������ 1������ ��°�� ���ٱ��� �÷� ��� �ٴ��� ������ ���� ������, ������ ���� ��� ������ ����ϰ�, ������ ���� ��� ������ ª�� �ϴ� ���� ����.";
        texts[10].text = $"�������� �ٴ��� �������� �Ҹ� ��ŭ ������ ���̿��� ���� ��ȣ�ϴ� �������� �丮���� �پ��ϸ�, ȸ, ��, ����, ���� ������ ���δ�.";
    }

    public void Button_bushiri()
    {
        canvasMenu.SetActive(false);
        canvasDict.SetActive(true);
        _scrollbar.value = 1;

        image.sprite = fishes[2];

        texts[0].text = $"�νø�";
        texts[1].text = $"100cm �̻�";
        texts[2].text = $"X";
        texts[3].text = $"X";
        texts[4].text = $"���ؾ� �չٴ� ������ �ؿ��� �����Ѵ�. �����帧�� ���� ���ų� ������ ���ڱ� �������� ���� Ư���� ��찡 �ƴϸ� �ٴ����� �ӹ��� ���� ���� ������, ������ ���鰡���̸� �����ϴٰ� ���̸� �߰��ϸ� �������� �������.";
        texts[5].text = $"ũ���� �ع�, �̳������� �η� ����Ѵ�. ������ �ȴٸ� ���忡�� ���� ���� �����̳� ���� Ȱ�� ���·� ����� �� ���ѵ�, �� ���� �ʹ� ū ������ ���� ������ �� ���� ���濡 �̸� �� �ִ�.";
        texts[6].text = $"������ ������ ���� ���� 1�� ���� ���δ�. �ٸ� �ñ⿡ ���� �� ���̴� �ð���� ��Ұ� �޶��� ���̴�. 3~5���� �������� �㿡 �� ���̰� 6~8���� ������ �չٴٷ� ������. 11�� ���ķ� �������� �㳬�ð� ���۵Ǹ� 12������ 3�������� ���� ������ ��ũ �����̴�.";
        texts[7].text = $"�νø��� ������ Ÿ�� �ٴϹǷ� �ֺ��� ���� �����밡 �帣�� �־�� ���� ����Ʈ�� ���� �ȴ�. ��ġ�� ���� ���� ���հ����� ���� �����̱⵵ �ϰ� �ع信 ��Ȥ�Ǿ� �������� ������ ������ ������ ���´�. �⺻�����δ� �ع��� �̿��� �νø��� �ҷ� ��� ����Ʈ�� �����.";
        texts[8].text = $"��\n����";
        texts[9].text = $"�ع��� ���� �ӵ��� ������� ������ ����� ���� �Ѹ��� ũ������ ǰ���Ѵ�. �ع��� �ڿ������� �귯���� ����ɵ��� �Ѵ�. �νø��� ���� ��� �̻��̴�. ���θ��� ���� ħ���ϵ��� ����.";
        texts[10].text = $"�νø��� ������ �����Ǵ� �ñ��� �ܿ�ö�� �߽����� ������ ���� ��ǰ�̴�. ��츸�� ���� �������� ȸ�� ���� ������ ���� ��� ���� �������� ���� �� ���� �����̴�.";
    }

    public void Button_soonguh()
    {
        canvasMenu.SetActive(false);
        canvasDict.SetActive(true);
        _scrollbar.value = 1;

        image.sprite = fishes[3];

        texts[0].text = $"����";
        texts[1].text = $"~ 80cm";
        texts[2].text = $"X";
        texts[3].text = $"X";
        texts[4].text = $"�츮������ ��� �ؿ��� �����ؿ� �ַ� �����ϳ� �� �ϱ� �� �ι��� ���̴� �������� ���� ���� ����. �ٴ�������� �ι��� ������ �ٴٿ����� ���� ����� ��, ������� �� �ϱ����� ���� �� ������.";
        texts[5].text = $"��ļ����� �ö�ũ��, ���� ���, ��Ǯ ���� �Դ´�. �̳��� �ع� ũ���� ���� �̳� ũ���� ����.";
        texts[6].text = $"���ؿ��� ��� 12������ ������̳� �ϱ� ������ ���ط� �Űܿ´�. ���� ������ ����� ������ �ܿ��̰� 4�� �߼�~5�� �ʼ��� �����̴�. ���ش� ��� 4������ �����ϱ� ������ ���� Ȱ���ϰ� �����ϴ� �ñ�� 5~10���̴�. ���ش� �ʰ������ �ܿ���� ��� �� �������� ���س� ����ó�� ����ð� ���������� �ʴ´�.";
        texts[7].text = $"�������� ���������� ���� ������ ������ ��Ҷ�� �ð��뿡 ���� ��� ����Ѵ�. ������ ������ ����Ű���� �ع����� ��� �ҷ��鿩 �ΰ����� ����Ʈ�� �����.";
        texts[8].text = $"��\n����";
        texts[9].text = $"����� ǥ���� ȸ���ϹǷ� è�� Ÿ�̹��� �ٸ���. ������ ������ ���������� ������ è���ϴ� ���� ���� Ȯ���� ����. �ع信 ���ε� ������ ����� ������ Ȯ�εǴµ��� ������ ���� �ʴ´ٸ� ������ �� �ܰ� ���ð� ����ϰų� �̳��� ũ�⸦ �۰� �Ѵ�.";
        texts[10].text = $"����� ���� ����� �ղ��� ������ ���� ���� ����� �ƴϴ�. �ܿ� ���� �Ȱ� �� �ڸ�, ���� �Ծ �޴� ��� �Ӵ㵵 �ֵ�, �ܿ� ����� Ƚ������ ������ �ٸ� �丮�� ����� ��ǰ�̴�.";
    }

    public void Button_uruk()
    {
        canvasMenu.SetActive(false);
        canvasDict.SetActive(true);
        _scrollbar.value = 1;

        image.sprite = fishes[4];

        texts[0].text = $"�췰";
        texts[1].text = $"�� 40cm";
        texts[2].text = $"X";
        texts[3].text = $"23cm ����";
        texts[4].text = $"���� 10~100m�� ������ �������뿡�� �ַ� �����Ѵ�. ������ �ܿ￡ �������� �̵��Ͽ� �����ϴ� ����ȸ���� �Ѵ�. ����� ���ٴϴ� ���ʿ� �Բ� �̵��Ѵ�. �㿡�� ǥ���̳� �������� ���� �������� ������ ������ ������ �̷�� Ȱ���ϰ� �����δ�.";
        texts[5].text = $"���� ���, ��¡��� ���� �Դ� ���ļ� �����, �̳��� û�������̳� �̲ٶ���, ��¡�� ���� ����Ѵ�. ������ �췰�� ���̳� ���ú��� ���ð� �����Ѵ�.";
        texts[6].text = $"���ش� ��ö 5~6���� ����ö 9~11���� �� ���̸� ���ؾȿ����� ����ö���� ��ö������ �����̴�.";
        texts[7].text = $"�������� ��Ʈ����Ʈ ����, ������ �ʼ� �α�, �ڰ���, ��������, Ȩ�� ������ ����Ʈ��. �������� �ʴ� ���� �������� ���� ƴ���� ���� �ֱ⵵ �Ѵ�.";
        texts[8].text = $"���\n����";
        texts[9].text = $"�췰�� ����ó�� �ӹ��ٰ� ���ݱǿ� ���� �� ���������� Ƣ��� ���� �ٽ� �ǵ��ư���. �׸�ŭ ������ ��Ź�ϰ� Ȯ���ϴ�. è���� ������ �췰�� ���� ������ �� �������� �ջ�Ǳ� ���� ����⵵ ��������Ƿ� Ȯ���� è���� �ʱ����п� �Ű��� ��� �Ѵ�.";
        texts[10].text = $"�췰�� �����ο��Ե� �ĵ����� ���� �Ϲ��ε鿡�Ե� �α� ����̴�. �� �� �������� Ȱ���� ���� ȸ�� �����̴�. ���� �������� �ſ����� ���� ����. �׹ۿ��� ����, ��, ���� �� � �丮���� �� �´´�.";
    }

    public void Button_limyeonsu()
    {
        canvasMenu.SetActive(false);
        canvasDict.SetActive(true);
        _scrollbar.value = 1;

        image.sprite = fishes[5];

        texts[0].text = $"�ӿ���";
        texts[1].text = $"27 ~ 50cm";
        texts[2].text = $"X";
        texts[3].text = $"X";
        texts[4].text = $"���� 100~200m ������ ������ ���� �ٴ��� ������ �ڰ��� �� �������뿡 �ַ� �����Ѵ�.";
        texts[5].text = $"��ļ� ����� �ӿ������� �̳��� ũ���� �ַ� ����Ѵ�.";
        texts[6].text = $"�ӿ����� ���ô� ö���� ���ؿ����� �̷������. �ӿ������ ������ ���� 1~2������ ���׿����� ����� �巯������, 3~4�� ������ ���� ������ �������濡���� �ӿ����� ������ ���� ����. �̶����ʹ� ���� �Ϻ� �������� 3~4���� �ַ� ���̱� �����Ѵ�. ";
        texts[7].text = $"�ӿ������ �ؼ������� �� �������� �� �ٴ��� ������� ���ð� �� �ȵȴ�. ������ ���� �ٴ��� �Ϲ��̰ų� ��Ʈ�����尡 ������ �ڸ�, ���ʼ��� ���� ��� ���� ���� ����Ʈ�̴�.";
        texts[8].text = $"��\n����";
        texts[9].text = $"�ӿ������� ������ ��ǽ����� ���µ� � �����̸� �ٷ� è���ϴ� ���� ����. ��ü�ϸ� �ٴ��� ���ѹ��� �����Ⱑ ��������⵵ �Ѵ�. �ӿ������ ũ�⿡ ���� ���� ���� ���Ƿ� ���˴��� ź���� �̿��� õõ�� �����.";
        texts[10].text = $"�ӿ������ �񸰳��� ���� ���õ� �＼���� �ʰ� �Ͼ� �ӻ��� �ε巯�� ���ִ� �����̴�.";
    }

    public void Button_chamdom()
    {
        canvasMenu.SetActive(false);
        canvasDict.SetActive(true);
        _scrollbar.value = 1;

        image.sprite = fishes[6];

        texts[0].text = $"����";
        texts[1].text = $"~ 90cm";
        texts[2].text = $"X";
        texts[3].text = $"24cm ����";
        texts[4].text = $"� ������ ���� ���� ������ ��Ȱ�ϴٰ� 2~3�� �ڶ� �ڿ� ���� 20~300m�� ������ �̵��Ѵ�. �츮���� �� �ؿ��� �����Ѵ�.";
        texts[5].text = $"������, ���, �ٸ�� ���� �԰� ��� ���� �̳��� �ַ� ũ���� ����Ѵ�. ������, �ֱ� ��� ���÷� ������ �� ���� ���̴� ���� Ȯ�εǸ鼭 ��� ���ð� ����ȭ�ǰ� �ִ�.";
        texts[6].text = $"4���̸� �չٴٿ������� �������� �ҽ��� ���ĵǾ� ���ٰ� 5~7���̸� ���ر��� Ȯ��Ǿ� ��� ������ ��� ȣȲ���� �ٲ��. ���� ������ 4������ �����Ͽ� 5~6���� ��ũ ������ �°�, ���Ŀ��� �������� ������ ������ �۾����� �����ϴ� 9~11���� ��ũ ������ ���� ������ ���δ�.";
        texts[7].text = $"�������ÿ� ������ ����Ʈ�� ������ �ַ� �Ϲ����� �̷���� ��, ũ�� ���� ���ʰ� �ߴ��� �����̳� �����̴�. ������ ���� ���� ���ɿ��� ���� �� ������ ���� 20~60m���� �ֿ� ����Ʈ�̴�.";
        texts[8].text = $"����\n����";
        texts[9].text = $"������ �������� �ϴ� �������� �� �� �ִ�. ������ ���������� ��Ȳ���� ���� �״�� ���Ծ��� ������ ����Ѵ�. è�� ���� �� Ư���� ó�ڴ� �ൿ�� ��Ǯ���ϴµ�, �������� ��� ��ȭ�� ���� ������ ���� �ʴ�. ���ô��� ���� ���ϸ� �����ϸ鼭 ��ü�� ź���� �����ϸ� ������ �ӵ��� ����ø���.";
        texts[10].text = $"ü���� �Ƹ��ٿ� ���ٴ��� ���ա�, ���ٴ��� ���ڡ� ��� �Ҹ���� ������ ���� ���� ���� �丮 ���� ġ��, ���������� �����ϴ�.";
    }

    public void Button_hakkongchi()
    {
        canvasMenu.SetActive(false);
        canvasDict.SetActive(true);
        _scrollbar.value = 1;

        image.sprite = fishes[7];

        texts[0].text = $"�в�ġ";
        texts[1].text = $"�� 40cm";
        texts[2].text = $"X";
        texts[3].text = $"X";
        texts[4].text = $"���� 50m �̳��� �����̳� ��, ȣ�� ��� ���� ���� �����Ѵ�. ���� �������� �������� �̵��ߴٰ�, ������ �ܿ￡�� �������� ��������.";
        texts[5].text = $"���� ������ �ö�ũ���̳� ����, �� ���� �ַ� �Դ� �в�ġ�� �̳��� ������ ũ���� ������.";
        texts[6].text = $"�츮���� ���ؿ����� �� �� �ִ� �������� �ܿﳬ�� ������ ���� ���µ� �в�ġ�� �ܿﳬ�ÿ� �־ ������ �����̴�. 11��~3���� �����̰� ������ 4�������� ���̴� ��찡 �ִ�.";
        texts[7].text = $"������ ��� ���ð� �̷������ ũ���̳� �����̸� �ع����� �����־�  ���������� ����Ʈ�� ������ش�. ���� ǥ���� �����ϴ� ������� 1~2m ���� ǥ������ ���´�. �в�ġ�� ������ ���� �ʴ� ��, �Ĺ��� ���̳� �� �帧�� ������ ��ҿ� ��� �����ٴѴ�.";
        texts[8].text = $"��\n����";
        texts[9].text = $"�в�ġ�� ���� �����̳� ����, ���δ� ���˴븦 �ֵθ��� �Ҹ����� �ΰ��ϰ� �����ϹǷ� �� �� ������ ������ ���ø� �ؾ� ���� ������ �ø� �� �ִ�.";
        texts[10].text = $"�в�ġ�� ȸ ���� �ſ� ����ϰ� �Ǹ��� ���̴�. �ұݱ��̷ε� ������, ������ �����ַε� ���� ���δ�.";
    }

    public void Button_godeunguh()
    {
        canvasMenu.SetActive(false);
        canvasDict.SetActive(true);
        _scrollbar.value = 1;

        image.sprite = fishes[8];

        texts[0].text = $"�����";
        texts[1].text = $"30 ~ 40cm";
        texts[2].text = $"4,5,6�� �� �� ��";
        texts[3].text = $"21cm ����";
        texts[4].text = $"�����, �뼭��, �ε����� �´� �� �ƿ��� �ؿ��� �θ� �����Ѵ�. ǥ�� �Ǵ� ǥ�����κ��� 300m �̳��� ������ �����Ѵ�. ����ȸ���� �ϸ�, �Ϲݱ��� �����ϴ� ���� ������ ����ϴ� ����ö�� �������� �̵��� �ϰ� �ܿ�ö���� �������� �̵��Ѵ�.";
        texts[5].text = $"������ ������, ��¡��, ���� ����� ��Ƹ�����, Ž�ļ��� �־� ���� ��� ���ø� �Ѵ�.";
        texts[6].text = $"�������� �������� ���ؿ� ���ؿ� ���� ���� ��Ÿ����. �� �ñ�� ����� ���� �Ŀ��� �����̴� ���հ��� ��ġ�� ��� �޷���� Ž�ļ��� ���̱� ������ ���� ���� ���δ�. ���ش� 7~9��, ���ش� 9~11�� ����� ���� ��Ÿ����.";
        texts[7].text = $"- ���������� ��Ȱ�� ������ ���κ��� �ְ� ����Ʈ�� ������. ���� ���̸� ���� �ױ������ε� �����Ƿ� ������ ���� ���� ����� �Ѵ�.\n- ���ϴ� ����Ʈ�� �ع��� �ѷ� ���������� ����Ʈ�� ����⵵ �Ѵ�. ";
        texts[8].text = $"���\n����";
        texts[9].text = $"���� �ø��� �ݹ� �װ� ������ ���� �������Ƿ� ���� ��� �Ǹ� �̾� �����𷯿� ��� ���� ����. �ټ�Ȯä�� ��� �� ������ ���� �ٷ� ���ƿø��� ���� ���˴븦 ��¦ è���ϰ� �ٽ� �����Ͽ� �� ��° ������ ��ٸ��⸦ ����ϸ� �ٴø��� ������ ���� �ø� �� �ִ�.";
        texts[10].text = $"������ ��Ǫ�� ������ ��ǥ���ڷ� ������ �������Գ� �ǰ��� ���� ������ �ִ� �����̴�. ���̷� �Ծ �������� �پ��� �丮�� Ȱ���� ���� �� �ִ�.";
    }

    public void Button_kwanguh()
    {
        canvasMenu.SetActive(false);
        canvasDict.SetActive(true);
        _scrollbar.value = 1;

        image.sprite = fishes[9];

        texts[0].text = $"���� (��ġ)";
        texts[1].text = $"60 ~ 80cm";
        texts[2].text = $"X";
        texts[3].text = $"35cm ����";
        texts[4].text = $"���ѹα��� �Ϻ�, �߱� ������ ������ ����� ���� ������ ������ �ְ�, ���� 10~200m ���̿� ��ġ�� �� �ٴ��� �ַ� ��ȣ�Ѵ�. ��Ÿ��� �̵��ϱ⿡�� ���� �Ƿ��� �پ�� ������ �ѹݵ� �Ϻ� ���������� ������ ���� �ι��� ��⵵ �Ѵ�.";
        texts[5].text = $"�̲ٶ���, ��¡���, û�������� ���� ����Ѵ�. �빰�� ���ؼ���� ����ִ� ��ġ, ���, ������, ������ ���� ũ�� 12~15cm ������ ��� ����Ѵ�.";
        texts[6].text = $"���ش� 4������ ������ �˸��� ���ش� 5������ ������ ���۵Ǹ� 7~8���� ���� ��ũ�̰�, 10������ �����ϴ�. �ַ� ���� �ֺ����� �����ϱ� ������ ���ؿ��� ���� �ϴ� ���� �߿� �ϳ��̱⵵ �ϴ�.";
        texts[7].text = $"- ���� ������ ���� �Ϲ����볪 ���ʰ� ���� �� ������ ���̰� �Ǵ� ���� �����Ⱑ �� ���̰� ��� �����ϱ� ���� ������ �����.\n- ���ʳ� ħ�� ���� ���鿡���� ���ȿ� ���� ������ ���� ���� ū �빰�� ���� ��ȸ�� ����.";
        texts[8].text = $"����\n����";
        texts[9].text = $"�ذɸ��� ���� ����Ʈ������ �������� ������ �� ª�� ��������ν� �ٴ��� ���� ������ ���� 1~2m ���� �÷��� �̳��� �ʹ� �� ���� �ʰ� �Ѵ�. ����, �γ����� ������ è���� ���θ��� ������ ����.";
        texts[10].text = $"����� ���� �پ�� ������� ���Ƽ� �췰�� ���Ҿ� �Ŀ����� ���� ��ĵǰ��ִ�. ����� �ַ� ȸ�� �԰�, ȸ�� �߰� ���� �������� �ſ����� ���� �Դ´�. �� �ۿ��� Ƣ������ �Ա⿡�� ����.";
    }

    public void Button_nonguh()
    {
        canvasMenu.SetActive(false);
        canvasDict.SetActive(true);
        _scrollbar.value = 1;

        image.sprite = fishes[10];

        texts[0].text = $"���";
        texts[1].text = $"50 ~ 100cm";
        texts[2].text = $"X";
        texts[3].text = $"30cm";
        texts[4].text = $"������ ���������� ���̸� �Ա� ���� ������ ����� ���� �ٴٷ� �̵��ϰ�, �ܿ�ö���� ���� ���� �ܿ��� ���� ���Ͽ� ������ ���� ������ �̵��Ѵ�. � ������ ����� �����Ͽ� ������ ������ ����� �ٴٷ� ������, �������� �� �ϱ����� �Ž��� �Դٰ� ������ �Ǹ� ���� �ٴٷ� �̵��Ѵ�.";
        texts[5].text = $"���ļ��� ��� ������ ������ �̳��� û�������̴�. û�������̴� �ٴÿ� �� ������ ��� ���� �ƴ϶� ���Դ� �ټ� ����, ���ð� ���� û�������̶�� �� ���� ���� �Ѳ����� ���.";
        texts[6].text = $"�츮���󿡼��� ���� �߳��ο� ���� �ο��� �����ϰ� �ִµ� �ַ� ���ؾȿ��� ��� ���ð� �̷������ 5���� �Ǹ� ��� ���� �ñ⿡ ���� �����Ѵ�. Ư�� 6~10���� �ְ��� ��� ���� �ñ��� �� �� �ִ�.";
        texts[7].text = $"- ���������� ����� ���� �ֺ��̳� ������ ������ �帣�� ��Ұ� �����̴�.\n- ������ �� �� �κ��� ���� ������ ���� ���ɵ� ���� ���� �ָ�Ǵ� ����Ʈ��.";
        texts[8].text = $"��\n����";
        texts[9].text = $"ä�� 40~50m ���� �ָ� �����ٴ� �������� ���ÿ� ���Ѵ�. � ������ �������� ���� ���˴븦 ������ ��� è���� �Ѵ�. ���� ������ ������ ���� ������ ��ĥ�� ������ �ٴ��� �������⵵ �ϹǷ� �����Ӱ��� �����ϴ�.";
        texts[10].text = $"7�� ���� �ٶ󺸱⸸ �ص� ���� �ȴٴ� ������ �ֵ��� ������ ���� ���� �ٸ� ������� �ܹ��� �Է��� ������ ���� ��ǥ���� ���� ��������� ������. �ַ� ��, ȸ ������ �Դ´�.";
    }

    public void Button_kajami()
    {
        canvasMenu.SetActive(false);
        canvasDict.SetActive(true);
        _scrollbar.value = 1;

        image.sprite = fishes[11];

        texts[0].text = $"���ڹ� (���ٸ�)";
        texts[1].text = $"�� 30cm";
        texts[2].text = $"12�� ~ 1��";
        texts[3].text = $"20cm ����";
        texts[4].text = $"�ٴ��� �𷡿� �������� �� ���������� �����ϸ�, �츮���� ���ؾ��� ��� �������� �ܿ�ö�� �������� �̵��Ͽ� ���ֵ� ��ó���� �ܿ��� ����, ���� �Ǹ� �������� ���� ���� �̵��Ѵ�. �ٴ� �عٴڿ��� ��Ȱ�ϱ� �����ϸ�, �� �ٴڰ� ���翡 ������ ���·� ������ ����� ġ�鼭 �ַ� ��Ȱ�Ѵ�.";
        texts[5].text = $"�ַ� �������̷�, ������, ����� ���� �ַ� �Դ� ���ٸ��� �̳��� ���ϱ� ���� û�������̸� ����ϴ�. ";
        texts[6].text = $"���ٸ� ���� ������ ���������� 3������ 5���� �����̸�, 1~2���� ����� ��ġ�� 3������ ������ ���� �����ϸ� 4~5���̸� ������ ���� �� ���� ����.";
        texts[7].text = $"- �������� ���� ���̳� ���κ��� ������ ���� �ֿ� ����Ʈ�� �ȴ�.\n- ������ ��ΰ� �Ǵ� ���ڸ��� ������ ������ ���ٸ��� �̵��ϴ� ��� �̹Ƿ� ���� ����Ʈ�� �ȴ�.\n- ���ٸ��� ���� �纸�ٴ� ��� ���� �𷡰� �ִ� ���� ����Ʈ�̴�. �ؼ������̳� ������� �𷡹� �����̰�, �ذɸ��� ���� ��� �����ϱ� ���� ����Ʈ�̴�.";
        texts[8].text = $"���Ÿ� ��ô\n����";
        texts[9].text = $"���ٸ��� ���� �۾� ���� �ٴ��� ����Ѵ�. ���ٸ��� ���� ������ ���� �Դ� ������ ���� ���������� ������ �Ծ����� �ִ� ���� �� �� �ִ�. �׸��� ���� �����̸� ���ٱ��� ���� �ø��� ���ٸ��� �����̸� ������ ��,  �ٴñ��� �����ϰԲ� �Ѵ�.";
        texts[10].text = $"�� ���ٸ� ���� ������ �Ӵ�ó�� ���ٸ��� ������ ���ڹ̷��� ��ö�� ���� ���� �ִ�. �̶��� ���ڹ� ���� ��Ļ� ����� ���� �ٰ� �ƴϴ�.";
    }

    public void Button_mangdoonguh()
    {
        canvasMenu.SetActive(false);
        canvasDict.SetActive(true);
        _scrollbar.value = 1;

        image.sprite = fishes[12];

        texts[0].text = $"���վ�";
        texts[1].text = $"35cm ����";
        texts[2].text = $"X";
        texts[3].text = $"X";
        texts[4].text = $"���ؾ�, ���ؾȿ� �����ϰ� �ִ� ���ȼ� �������. ���� ������ �������� ������ ��� ��� ������ ���ȿ� ���� ���� ���� ������ �̵��ϴ� ������ �ְ�, �����ÿ��� �ظ��� ����, ���� � �޶�پ� ��ݽ��� ���� ���� ������ �ִ�.";
        texts[5].text = $"��, ��������, ���� ���� ��ƸԴ� �����̴� �ļ��� ���� ������ ���̿� ���� ������ ���ϰ� ���ɵ� ����. û�������̸� �����̰�, ������ �� ���� ��ƸԴ´ٴ� ��ó�� ���� ���վ��� ���� ���� �̳��� ����ص� �ȴ�.";
        texts[6].text = $"���վ�� ���ؿ� ���� ���ȿ��� �ַ� ������. ���վ ���� ���� ũ�Ⱑ �Ƿ��� ��� 9�� �߼��� �Ѱܾ� �Ѵ�. �����̸� �����̴� � �չٴ� ���̴� �Ǹ�, �̸��Ͽ��� ���� �ִ�. �̶����� 11�� ���̳� 12�� �ʱ����� ���վ ���÷� �������� �ܿ￡ ��� ���� �ٴٷ� ���� ���ð� �� ���� �ʴ´�.";
        texts[7].text = $"- �й��� �买�� ���� �̵��ϴ� ���վ�� �й��� ������ �买�� ���������� �ֿ� ���ٱ��� ������ ���� ����Ʈ�̴�.";
        texts[8].text = $"���Ÿ� ��ô\n����";
        texts[9].text = $"�̳��� ���ϱ� ���� û�������̸� �ȴ�. �� �ۿ��� ������, �԰���, ���쿡�� �� ���δ�. ���� ���վ �� �̳��� �ᵵ �ȴ�. ���� ���� �买�� ���۵Ǹ� ���վ ����� ������ ��������.";
        texts[10].text = $"������� �޸� ���վ�� ���� ����. ȸ, ��, Ƣ�� �� ���� ���� �丮���� �ִ�.";
    }

    public void Button_minuh()
    {
        canvasMenu.SetActive(false);
        canvasDict.SetActive(true);
        _scrollbar.value = 1;

        image.sprite = fishes[13];

        texts[0].text = $"�ξ�";
        texts[1].text = $"60 ~ 90cm";
        texts[2].text = $"X";
        texts[3].text = $"33cm ����";
        texts[4].text = $"���ؿ� ���ؿ� �����Ѵ�. �ַ� ������ 40~120m�� ���ٴڿ��� ��Ȱ�ϸ�, ������ �ٴڿ� �ӹ��ٰ� ���� �Ǹ� ��� ���� ���ö� ���̸� ã�´�. ����ȸ���� �ϴµ�, �������� ���� ���ؿ��� ������ �ϰ� ���� �Ǹ� �������� �̵��Ͽ� ����⸦ ������ ���� �������� �����Ѵ�. �� �ñⰡ 6~9���� ���ص��ο��� ���س��θ� ���� ��õ �չٴٱ��� ��� �ξ �����Ѵ�.";
        texts[5].text = $"�ξ� ���ÿ��� ���������̰� ����̴�.";
        texts[6].text = $"�������� ������ 7�� �߼��̸� 8~9���� ��ũ �����̴�.";
        texts[7].text = $"�ξ�� ���󿡼� ���Ÿ� ��ô ���ø� �ַ��Ѵ�. ���� 10~20m ������ ������ ������ �ֺ��� �ֿ� ����Ʈ�̴�. ���߿��� ���� ���� ������ ���� ������ ����Ǿ� ����� ��Ҵ�.";
        texts[8].text = $"���Ÿ� ��ô\n����";
        texts[9].text = $"�ξ�� ������ ������ ������ �־ �����̳� ������ Ư�� �ΰ��ѵ� �α�ô�̳� �������� ������ ���� ������ ����Ƿ� �����ϴ� ���߿��� ������ �����ؾ� �Ѵ�. ������ ����Ʈ���� �ָ� �������� ä�� ������ �� �ָ� ������ ���� �����ϴ�.";
        texts[10].text = $"�ְ��� Ƚ�� �� �� ������ ������ �ִ� �ξ�� �� ���� �پ�� ������ ������ ���� �ø��� ��ǥ���� ���� �����̴�.";
    }

    public void Button_baengaedom()
    {
        canvasMenu.SetActive(false);
        canvasDict.SetActive(true);
        _scrollbar.value = 1;

        image.sprite = fishes[14];

        texts[0].text = $"������";
        texts[1].text = $"�� 50cm";
        texts[2].text = $"X";
        texts[3].text = $"X";
        texts[4].text = $"������ �Ϲ������� �����ϰ�, ġ����� ������ ���� ��Ȱ�ϸ�, ����� 2~6���� �Ѵ�. ���ؿ� ���ֵ��� ������ ���ؿ� �����Ѵ�.";
        texts[5].text = $"�𿡵��� ��ļ��̸鼭�� �ٴ���� �߿����� �幰�� �ķ��� ���� ���̷� ���ϴ� �ʽļ��̱⵵ �ϴ�. ������ ��ũ��, �ķ�����, ȫ�������� ���� �̳��� ����Ѵ�.";
        texts[6].text = $"���ؾ�, ���ؾ��� 5�� �߼����� 10�� �߼��� �����̸�, ���ֵ��� ���߿� ��������, 3~4���� ������̴�. 12�� �ʼ��� ���� �� �ٴ��� �𿡵� ������ ���� ���� �ñ��̸�, 1�� �߼��� �ѱ�� �������� �ް��� ��������.";
        texts[7].text = $"- �й��� �买�� ���ϰ� ��ġ�� �������� ������ ��θ� ������ � ���̳� ������ �ȴ�.\n- �𿡵��� ������ ���� ������ �������� ������ �������µ� �̷� �������� ���� ������ ���������ش�.\n- �������� �߰��� ���̴� ����, �������� ���� �� �κ�, ���ӿ� ���߿��� ���� �� ������ ��Ʈ����Ʈ�� ��� �ִ� ���� ����.";
        texts[8].text = $"��\n����";
        texts[9].text = $"�빰�� ���� ������ �������� ���˴븦 ����� ��� ��Ƽ�鼭 ���� ������ �Ѵ�. �������̳� ������ó�� ����� ��Ȳ������ �𿡵��� ������ ����� ������ ����Ȱ���� �Ѵ�. ���� �̶��� ä�� �ָ� ������ ���ٴ� �߹� ����� ���� �ܳ��ϴ� �� �����ϴ�.";
        texts[10].text = $"�ܿ� �𿡵��ϼ��� �⸧�Ⱑ ���� ������ �˵��� ������ ����. 35cm �̻� �����̶�� ȸ�� �ܿ� �켱�̰�, 30cm ���ϴ� ���̳� ������ �� ����.";
    }

    public void Button_bolak()
    {
        canvasMenu.SetActive(false);
        canvasDict.SetActive(true);
        _scrollbar.value = 1;

        image.sprite = fishes[15];

        texts[0].text = $"����";
        texts[1].text = $"�ִ� 35cm";
        texts[2].text = $"X";
        texts[3].text = $"15cm ����";
        texts[4].text = $"���ؾȰ� ���ؾȿ� �����ϰ�, Ư�� �泲 ���� �ؿ��� ���� �����ϰ� �ִ�. �ַ� ���� �ؾ��� ���� ������ �ִ� ���ʴ뿡 ������ ���� ��µ�, �ٸ� �������� �޸� �� ƴ�� �پ��� ���� �ƴ϶� ���� �α��� ȸ���ϰų� �������� �߸� ������ ������ ���� �� �ֱ⵵ �Ѵ�.";
        texts[5].text = $"���� �̳��� û��������, ũ�� �� �̳��� ���� ������ ������ ���� �ι����찡 �ֿ켱�̴�. �׷��� ������ ���̳� ���ú��ٴ� ��� ���ø� �ַ��Ѵ�.";
        texts[6].text = $"������ ������ ���� ���� 1�� ���� ���δ�. �ٸ� �ñ⿡ ���� �� ���̴� �ð���� ��Ұ� �޶��� ���̴�. 3~5���� �������� �㿡 �� ���̰� 6~8���� ������ �չٴٷ� ������. 11�� ���ķ� �������� �㳬�ð� ���۵Ǹ� 12������ 3�������� ���� ������ ��ũ �����̴�.";
        texts[7].text = $"���� �� ���� �׸��� ������ �� ����Ʈ��. ������ ������ �α�, ������ ���� �ֺ�, ����, �ڰ���, ���ʴ� � �����ϰ� �ִ�. �� ���� ���� ���� �׸���, �������� �Ʒ� � ����Ʈ�� �ȴ�.";
        texts[8].text = $"���\n����";
        texts[9].text = $"������ �Ϸ� ���� �������� ũ�� �ٲ��. ������ ������ ��ֹ��� �����ϰ� �㿡�� �����ο��� Ȱ���Ѵ�. Ȱ���� �ְ����� �̷�� ������� �߰�, ������ �븮���� ����.";
        texts[10].text = $"������ ������ �ұݱ����̴�. ���� �ұ��� �ѷ� ���� ���� ���� ���� ���� �ְ���. �׹ۿ��� ��, ������ �ص� ���� ���ִ�. ������ �� ���� �ܴ��� ������ ������ �־� Ƚ�����ε� ����.";
    }

    public void Button_back()
    {
        canvasMenu.SetActive(true);
        canvasDict.SetActive(false);
    }
}