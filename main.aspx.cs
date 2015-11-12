using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;
using System.Web;
using System.Web.UI.WebControls;
using System.Web.Services;

//using TestHorizonWebService.HorizonServiceDevo;
//using TestHorizonWebService.HorizonServiceDevoAPI;
using TestHorizonWebService.HorizonServiceLiveAPI;
//using TestHorizonWebService.HorizonServicePreview;
//using TestHorizonWebService.localhostHorizonService;
//using TestHorizonWebService.HorizonServiceWWW;
//using TestHorizonWebService.HorizonServiceLive_NoWWW;

namespace TestHorizonWebService
{
	public partial class main : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			_WebService = new HorizonServiceSoapClient();
			ServicePointManager.ServerCertificateValidationCallback += new RemoteCertificateValidationCallback(ValidateServerCertificate);
		}

		HorizonServiceSoapClient _WebService;
				
		// Items in Category
		//private void Button2_Click(object sender, EventArgs e)
		//{
		//  string user = TextBoxUser.Text;
		//  string password = TextBoxPassword.Text;
		//  string custno = TextBoxCustomer.Text;
		//  string category = TextBoxCategory.Text;

		//  //this.Enabled = false;
		//  PanelPostOrder.Visible = false;
		//  TextBoxResult.Visible = true;

		//  try
		//  {
		//    ItemsInCategoryResponse response = _WebService.Items(user, password, custno, category);
		//    if (response.Error)
		//    {
		//      TextBox1.Text = response.Message;
		//      return;
		//    }
		//    ItemsInCategoryCollection ic = response.Detail;
		//    TextBox1.Text = string.Empty;
		//    foreach (Category c in ic.Categories)
		//    {
		//      foreach (Item item in c.Items)
		//      {
		//        TextBoxResult.Text += item.ItemId + ": " + item.Description + "\n";
		//      }
		//    }
		//  }
		//  catch (Exception oops)
		//  {
		//  }
		//  //this.Enabled = true;
		//}

		//// Item by ID
		//private void Button3_Click(object sender, EventArgs e)
		//{
		//  string user = TextBoxUser.Text;
		//  string password = TextBoxPassword.Text;
		//  string custno = TextBoxCustomer.Text;
		//  string itemid = TextBoxItemId.Text;

		//  //this.Enabled = false;
		//  PanelPostOrder.Visible = false;
		//  TextBoxResult.Visible = true;

		//  try
		//  {
		//    SingleItemResponse response = _WebService.Item(user, password, custno, itemid);
		//    if (response.Error)
		//    {
		//      TextBox1.Text = response.Message;
		//      return;
		//    }
		//    ItemExtended item = response.Detail;
		//    TextBoxResult.Text = item.ItemId + " ... " + item.Description;
		//  }
		//  catch (Exception oops)
		//  {
		//  }
		//  //this.Enabled = true;
		//}

		// Post Order
//// Realtime Status
		//private void Button4_Click(object sender, EventArgs e)
		//{
		//  string user = TextBoxUser.Text;
		//  string password = TextBoxPassword.Text;
		//  string custno = TextBoxCustomer.Text;
		//  string itemIdList = TextBoxItemId.Text;

		//  TextBox1.Text = string.Empty;
		//  PanelPostOrder.Visible = false;
		//  PanelResult.Visible = true;
		//  TextBoxResult.Text = string.Empty;

		//  try
		//  {
		//    string[] itemIds = itemIdList.Replace(" ", "").Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
		//    APIResponse response = _WebService.GetRealtimeItemStatus(user, password, custno, itemIds);
		//    WriteResult(response, "Items");
		//  }
		//  catch (Exception oops)
		//  {
		//  }
		//}

		// Commonly Replaced Items
		//private void Button5_Click(object sender, EventArgs e)
		//{
		//  string user = TextBoxUser.Text;
		//  string password = TextBoxPassword.Text;
		//  string custno = TextBoxCustomer.Text;
		//  string itemid = TextBoxItemId.Text;

		//  PanelPostOrder.Visible = false;
		//  PanelResult.Visible = true;

		//  try
		//  {
		//    APIResponse response = _WebService.GetCommonlyReplacedItems(user, password, custno, itemid);
		//    if (response.Error)
		//    {
		//      TextBox1.Text = response.Message;
		//      return;
		//    }
		//    TextBox1.Text = string.Empty;
		//    TextBoxResult.Text = string.Empty;

		//    XmlDocument xml = new XmlDocument();
		//    xml.LoadXml(response.Value);
		//    XmlNodeList nodeList = xml.GetElementsByTagName("CommonlyReplacedItem");
		//    List<string> resultList = new List<string>();
		//    //foreach (CommonlyReplacedItem item in response.CommonReplacedItems)
		//    //{
		//    //  resultList.Add(string.Format("{0}\t{1}\t{2}\t{3}\t{4}", item.ItemId, item.Manufacturer, item.ManufacturerId, item.WebType, item.OnHand, item.Price));
		//    //}

		//    TextBoxResult.Text = string.Join("\r\n", resultList.ToArray());
		//  }
		//  catch (Exception oops)
		//  {
		//  }
		//}

		// Multiple Items by IDs
		//private void Button6_Click(object sender, EventArgs e)
		//{
		//  string user = TextBoxUser.Text;
		//  string password = TextBoxPassword.Text;
		//  string custno = TextBoxCustomer.Text;
		//  string itemIdList = TextBoxItemId.Text;

		//  TextBox1.Text = string.Empty;
		//  PanelPostOrder.Visible = false;
		//  PanelResult.Visible = true;
		//  TextBoxResult.Text = string.Empty;

		//  try
		//  {
		//    string[] itemIds = itemIdList.Replace(" ", "").Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
		//    APIResponse response = _WebService.GetMultipleItemDetail(user, password, custno, itemIds);

		//    if (response.Error)
		//    {
		//      TextBox1.Text = response.Message;
		//      return;
		//    }
		//    XmlDocument xml = new XmlDocument();
		//    xml.LoadXml(response.Value);
		//    XmlNodeList nodeList = xml.GetElementsByTagName("InventoryItemInfo");
		//    StringReader reader = new StringReader(response.Value);
		//    XDocument xdoc = XDocument.Load(reader);
		//    List<string> itemLineList = new List<string>();

		//    var items = xdoc.Descendants("InventoryItemInfo");
		//    foreach (XElement el in items.Descendants())
		//    {
		//      itemLineList.Add(string.Format("{0}\t\t{1}", el.Name, el.Value));
		//    }
		//    string itemLines = string.Join("\r\n", itemLineList.ToArray());
		//    TextBoxResult.Text = string.Format("{0}", itemLines);
		//  }
		//  catch (Exception oops)
		//  {
		//  }
		//}

		//// Master Inventory List
		//private void Button7_Click(object sender, EventArgs e)
		//{
		//  string user = TextBoxUser.Text;
		//  string password = TextBoxPassword.Text;
		//  string custno = TextBoxCustomer.Text;
		//  string itemIdList = TextBoxItemId.Text;

		//  TextBox1.Text = string.Empty;
		//  PanelPostOrder.Visible = false;
		//  PanelResult.Visible = true;
		//  TextBoxResult.Text = string.Empty;

		//  try
		//  {
		//    //this.Enabled = false;
		//    List<string> itemLineList = new List<string>();
		//    //int count = _WebService.CountMasterInventoryListPages();
		//    //int topPage = count;
				
		//    //for (int page = 0; page < topPage; page++)
		//    //{
		//    string[] itemIds = itemIdList.Replace(" ", "").Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
		//    //MasterInventoryListReponse response = _WebService.GetMasterInventoryList(user, password, custno, (page + 1));
		//    APIResponse response = _WebService.GetMasterInventoryList(user, password, custno);
		//    WriteResult(response, "InventoryItems");
		//  }
		//  catch (Exception oops)
		//  {
		//    TextBox1.Text = oops.Message;
		//  }
		//  finally
		//  {
		//    //this.Enabled = true;
		//  }
		//}

		//private void Button8_Click(object sender, EventArgs e)
		//{
		//  PanelPostOrder.Visible = true;
		//  PanelResult.Visible = true;
		//}

		//// GetDailySales
		//private void Button9_Click(object sender, EventArgs e)
		//{
		//  //this.Enabled = false;

		//  try
		//  {
		//    string user = TextBoxUser.Text;
		//    string password = TextBoxPassword.Text;
		//    string custno = TextBoxCustomer.Text;

		//    PanelPostOrder.Visible = false;
		//    PanelResult.Visible = true;
		//    APIResponse response = _WebService.GetDailySales(user, password, custno);
		//    WriteResult(response, "DailySales");
		//  }
		//  catch (Exception oops)
		//  {
		//  }
		//  finally
		//  {
		//    //this.Enabled = true;
		//  }
		//}

		//// BOM list
		//private void Button10_Click(object sender, EventArgs e)
		//{
		//  //this.Enabled = false;

		//  try
		//  {
		//    string user = TextBoxUser.Text;
		//    string password = TextBoxPassword.Text;
		//    string custno = TextBoxCustomer.Text;

		//    PanelPostOrder.Visible = false;
		//    PanelResult.Visible = true;
		//    APIResponse response = _WebService.GetBomList(user, password, custno);
		//    WriteResult(response, "BomList");
		//  }
		//  catch (Exception oops)
		//  {
		//  }
		//  finally
		//  {
		//    //this.Enabled = true;
		//  }
		//}

		//// BOM Components
		//private void Button11_Click(object sender, EventArgs e)
		//{
		//  //this.Enabled = false;

		//  try
		//  {
		//    string user = TextBoxUser.Text;
		//    string password = TextBoxPassword.Text;
		//    string custno = TextBoxCustomer.Text;
		//    string bomid = TextBoxItemId.Text;

		//    PanelPostOrder.Visible = false;
		//    PanelResult.Visible = true;
		//    APIResponse response = _WebService.GetBomComponents(user, password, custno, bomid);
		//    WriteResult(response, "Components");
		//  }
		//  catch (Exception oops)
		//  {
		//  }
		//  finally
		//  {
		//    //this.Enabled = true;
		//  }
		//}

		//private void Button12_Click(object sender, EventArgs e)
		//{
		//  string user = TextBoxUser.Text;
		//  string password = TextBoxPassword.Text;
		//  string custno = TextBoxCustomer.Text;
		//  string daysInput = TextBoxDays.Text;
		//  int days = 0;

		//  TextBox1.Text = string.Empty;
		//  PanelPostOrder.Visible = false;
		//  PanelResult.Visible = true;
		//  TextBoxResult.Text = string.Empty;

		//  bool ok = int.TryParse(daysInput, out days);
		//  if (!ok)
		//  {
		//    TextBox1.Text = "Enter a number";
		//    return;
		//  }

		//  try
		//  {
		//    APIResponse response = _WebService.GetInventoryListChanges(user, password, custno, daysInput);
		//    WriteResult(response, "InventoryItems");
		//  }
		//  catch (Exception oops)
		//  {
		//  }
		//}

		//private void Button13_Click(object sender, EventArgs e)
		//{
		//  string user = TextBoxUser.Text;
		//  string password = TextBoxPassword.Text;
		//  string custno = TextBoxCustomer.Text;
		//  string itemid = TextBoxItemId.Text;

		//  PanelPostOrder.Visible = false;
		//  PanelResult.Visible = true;

		//  try
		//  {
		//    APIResponse response = _WebService.GetRecommendedItems(user, password, custno, itemid);
		//    WriteResult(response, "InventoryItems");
		//  }
		//  catch (Exception oops)
		//  {
		//  }
		//}

		//private void Button14_Click(object sender, EventArgs e)
		//{
		//  string user = TextBoxUser.Text;
		//  string password = TextBoxPassword.Text;
		//  string custno = TextBoxCustomer.Text;
		//  string sono = TextBoxSono.Text;

		//  //this.Enabled = false;
		//  PanelPostOrder.Visible = false;
		//  PanelResult.Visible = true;
		//  TextBoxResult.Visible = true;

		//  try
		//  {
		//    APIResponse response = _WebService.GetSalesOrder(user, password, custno, sono);
		//    WriteResult(response, "SalesOrder");
		//  }
		//  catch (Exception oops)
		//  {
		//  }
		//  //this.Enabled = true;
		//}

		//private void Button15_Click1(object sender, EventArgs e)
		//{
		//  string user = TextBoxUser.Text;
		//  string password = TextBoxPassword.Text;
		//  string custno = TextBoxCustomer.Text;
		//  string sono = TextBoxSono.Text;

		//  //this.Enabled = false;
		//  PanelPostOrder.Visible = false;
		//  PanelResult.Visible = true;
		//  TextBoxResult.Visible = true;

		//  try
		//  {
		//    APIResponse response = _WebService.GetTrackingNumber(user, password, custno, sono, "", "", "");
		//    WriteResult(response, "TrackingNumbers");
		//  }
		//  catch (Exception oops)
		//  {
		//  }
		//  //this.Enabled = true;
		//}

		private void ButtonPostOrder_Click(object sender, EventArgs e)
		{
			//this.Enabled = false;
			string user = TextBoxUser.Text;
			string password = TextBoxPassword.Text;
			string custno = TextBoxCustomer.Text;
			string orderXml = TextBoxOrderXML.Text;

			TextBox1.Text = string.Empty;
			List<string> responseList = new List<string>();

			try
			{
				PostOrderResponse[] responses = _WebService.PostOrder(user, password, custno, orderXml);
				foreach (PostOrderResponse response in responses)
				{
					string responseMessage = string.Format("Order ID: {0} :: {1}", response.OrderId, response.Message);
					responseList.Add(responseMessage);
					foreach (AddToCartResponse additemresponse in response.AddToCartResponses)
					{
						responseList.Add(string.Format("\t{0}: {1}", additemresponse.ItemId, additemresponse.ResponseMessage));
					}
				}
				TextBoxResult.Text = string.Join("\r\n", responseList.ToArray());
			}
			catch
			{
			}
			finally
			{
				//this.Enabled = true;
			}
		}

		public void OnConfirm(object sender, EventArgs e)
		{
			string confirmValue = Request.Form["confirm_value"];
			if (confirmValue == "Yes")
			{
					this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You clicked YES!')", true);
			}
			else
			{
					this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You clicked NO!')", true);
			}
		}

		public static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			if (sslPolicyErrors == SslPolicyErrors.None)
			{
				return true;
			}
			//else if (MessageBox.Show("The server certificate is not valid.\nAccept?", "Certificate Validation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			//{
			//  return true;
			//}
			else
			{
				return false;
			}
		}

		private void WriteResult(APIResponse response, string pValueRoot)
		{
			if (response == null)
			{
				TextBox1.Text = "No response object.";
				return;
			}
			if (response.Error)
			{
				TextBox1.Text = response.Message;
				return;
			}
			if (response.Value == null)
			{
				TextBox1.Text = "No response value.";
				return;
			}
			if (response.Value.Length == 0)
			{
				TextBox1.Text = "No response value.";
				return;
			}
			if (pValueRoot == null)
			{
				TextBox1.Text = "No root value.";
				return;
			}
			if (pValueRoot.Length == 0)
			{
				TextBox1.Text = "No root value.";
				return;
			}

			XmlDocument xml = new XmlDocument();
			StringReader reader = new StringReader(response.Value);
			XDocument xdoc = XDocument.Load(reader);
			List<string> itemLineList = new List<string>();

			var items = xdoc.Descendants(pValueRoot);
			foreach (XElement el in items.Descendants())
			{
				itemLineList.Add(string.Format("{0}\t\t{1}", el.Name, el.Value));
			}
			string itemLines = string.Join("\r\n", itemLineList.ToArray());
			TextBoxResult.Text = string.Format("{0}", itemLines);
		}
		
		// Category List
		protected void Button1_Click(object sender, EventArgs e)
		{
			//this.Enabled = false;
			try
			{
				string user = TextBoxUser.Text;
				string password = TextBoxPassword.Text;
				string custno = TextBoxCustomer.Text;

				PanelPostOrder.Visible = false;
				PanelResult.Visible = false;

				CategoryResponse response = _WebService.CategoryList(user, password, custno);
				if (response.Error)
				{
					TextBox1.Text = response.Message;
					return;
				}
				CategoryCollection cc = response.Detail;
				TextBox1.Text = string.Empty;
				foreach (DisplayCategory c in cc.DisplayCategories)
				{
					TextBox1.Text += c.ID + ": " + c.Description + "\n";
				}
			}
			catch (Exception oops)
			{
			}
			finally
			{
				//this.Enabled = true;
			}
		}

		// Items in Category
		protected void Button2_Click1(object sender, EventArgs e)
		{
			string user = TextBoxUser.Text;
			string password = TextBoxPassword.Text;
			string custno = TextBoxCustomer.Text;
			string category = TextBoxCategory.Text;

			//this.Enabled = false;
			PanelPostOrder.Visible = false;
			TextBoxResult.Visible = true;

			try
			{
				ItemsInCategoryResponse response = _WebService.Items(user, password, custno, category);
				if (response.Error)
				{
					TextBox1.Text = response.Message;
					return;
				}
				ItemsInCategoryCollection ic = response.Detail;
				TextBox1.Text = string.Empty;
				foreach (Category c in ic.Categories)
				{
					foreach (Item item in c.Items)
					{
						TextBoxResult.Text += item.ItemId + ": " + item.Description + "\n";
					}
				}
			}
			catch (Exception oops)
			{
			}
			//this.Enabled = true;
		}

		// Item by ID (Master Item List)
		protected void Button3_Click1(object sender, EventArgs e)
		{
			string user = TextBoxUser.Text;
			string password = TextBoxPassword.Text;
			string custno = TextBoxCustomer.Text;
			string itemid = TextBoxItemId.Text;

			//this.Enabled = false;
			PanelPostOrder.Visible = false;
			TextBoxResult.Visible = true;

			try
			{
				SingleItemResponse response = _WebService.Item(user, password, custno, itemid);
				if (response.Error)
				{
					TextBox1.Text = response.Message;
					return;
				}
				ItemExtended item = response.Detail;
				TextBoxResult.Text = item.ItemId + " ... " + item.Description;
			}
			catch (Exception oops)
			{
			}
			//this.Enabled = true;
		}

		// Realtime Status (BOM List)
		protected void Button4_Click1(object sender, EventArgs e)
		{
			string user = TextBoxUser.Text;
			string password = TextBoxPassword.Text;
			string custno = TextBoxCustomer.Text;
			string itemIdList = TextBoxItemId.Text;

			TextBox1.Text = string.Empty;
			PanelPostOrder.Visible = false;
			PanelResult.Visible = true;
			TextBoxResult.Text = string.Empty;

			try
			{
				string[] itemIds = itemIdList.Replace(" ", "").Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
				APIResponse response = _WebService.GetRealtimeItemStatus(user, password, custno, itemIds);
				WriteResult(response, "Items");
			}
			catch (Exception oops)
			{
			}
		}

		// Items
		protected void Button5_Click1(object sender, EventArgs e)
		{
			string user = TextBoxUser.Text;
			string password = TextBoxPassword.Text;
			string custno = TextBoxCustomer.Text;
			string itemid = TextBoxItemId.Text;

			PanelPostOrder.Visible = false;
			PanelResult.Visible = true;

			try
			{
				APIResponse response = _WebService.GetCommonlyReplacedItems(user, password, custno, itemid);
				if (response.Error)
				{
					TextBox1.Text = response.Message;
					return;
				}
				TextBox1.Text = string.Empty;
				TextBoxResult.Text = string.Empty;

				XmlDocument xml = new XmlDocument();
				xml.LoadXml(response.Value);
				XmlNodeList nodeList = xml.GetElementsByTagName("CommonlyReplacedItem");
				List<string> resultList = new List<string>();
				//foreach (CommonlyReplacedItem item in response.CommonReplacedItems)
				//{
				//  resultList.Add(string.Format("{0}\t{1}\t{2}\t{3}\t{4}", item.ItemId, item.Manufacturer, item.ManufacturerId, item.WebType, item.OnHand, item.Price));
				//}

				TextBoxResult.Text = string.Join("\r\n", resultList.ToArray());
			}
			catch (Exception oops)
			{
			}
		}

		//Realtime Status
		protected void Button6_Click1(object sender, EventArgs e)
		{
			string user = TextBoxUser.Text;
			string password = TextBoxPassword.Text;
			string custno = TextBoxCustomer.Text;
			string itemIdList = TextBoxItemId.Text;

			TextBox1.Text = string.Empty;
			PanelPostOrder.Visible = false;
			PanelResult.Visible = true;
			TextBoxResult.Text = string.Empty;

			try
			{
				string[] itemIds = itemIdList.Replace(" ", "").Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
				APIResponse response = _WebService.GetMultipleItemDetail(user, password, custno, itemIds);

				if (response.Error)
				{
					TextBox1.Text = response.Message;
					return;
				}
				XmlDocument xml = new XmlDocument();
				xml.LoadXml(response.Value);
				XmlNodeList nodeList = xml.GetElementsByTagName("InventoryItemInfo");
				StringReader reader = new StringReader(response.Value);
				XDocument xdoc = XDocument.Load(reader);
				List<string> itemLineList = new List<string>();

				var items = xdoc.Descendants("InventoryItemInfo");
				foreach (XElement el in items.Descendants())
				{
					itemLineList.Add(string.Format("{0}\t\t{1}", el.Name, el.Value));
				}
				string itemLines = string.Join("\r\n", itemLineList.ToArray());
				TextBoxResult.Text = string.Format("{0}", itemLines);
			}
			catch (Exception oops)
			{
			}
		}

		// Master Inventory List
		protected void Button7_Click1(object sender, EventArgs e)
		{
			string user = TextBoxUser.Text;
			string password = TextBoxPassword.Text;
			string custno = TextBoxCustomer.Text;
			string itemIdList = TextBoxItemId.Text;

			TextBox1.Text = string.Empty;
			PanelPostOrder.Visible = false;
			PanelResult.Visible = true;
			TextBoxResult.Text = string.Empty;

			try
			{
				//this.Enabled = false;
				List<string> itemLineList = new List<string>();
				//int count = _WebService.CountMasterInventoryListPages();
				//int topPage = count;
				
				//for (int page = 0; page < topPage; page++)
				//{
				string[] itemIds = itemIdList.Replace(" ", "").Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
				//MasterInventoryListReponse response = _WebService.GetMasterInventoryList(user, password, custno, (page + 1));
				APIResponse response = _WebService.GetMasterInventoryList(user, password, custno);
				WriteResult(response, "InventoryItems");
			}
			catch (Exception oops)
			{
				TextBox1.Text = oops.Message;
			}
			finally
			{
				//this.Enabled = true;
			}
		}

		//Recommended Items
		protected void Button8_Click1(object sender, EventArgs e)
		{
			PanelPostOrder.Visible = true;
			PanelResult.Visible = true;
		}

		// GetDailySales
		protected void Button9_Click1(object sender, EventArgs e)
		{
			//this.Enabled = false;

			try
			{
				string user = TextBoxUser.Text;
				string password = TextBoxPassword.Text;
				string custno = TextBoxCustomer.Text;

				PanelPostOrder.Visible = false;
				PanelResult.Visible = true;
				APIResponse response = _WebService.GetDailySales(user, password, custno);
				WriteResult(response, "DailySales");
			}
			catch (Exception oops)
			{
			}
			finally
			{
				//this.Enabled = true;
			}
		}

		// BOM list
		protected void Button10_Click1(object sender, EventArgs e)
		{
			//this.Enabled = false;

			try
			{
				string user = TextBoxUser.Text;
				string password = TextBoxPassword.Text;
				string custno = TextBoxCustomer.Text;

				PanelPostOrder.Visible = false;
				PanelResult.Visible = true;
				APIResponse response = _WebService.GetBomList(user, password, custno);
				WriteResult(response, "BomList");
			}
			catch (Exception oops)
			{
			}
			finally
			{
				//this.Enabled = true;
			}
		}

		// BOM Components
		protected void Button11_Click1(object sender, EventArgs e)
		{
			//this.Enabled = false;

			try
			{
				string user = TextBoxUser.Text;
				string password = TextBoxPassword.Text;
				string custno = TextBoxCustomer.Text;
				string bomid = TextBoxItemId.Text;

				PanelPostOrder.Visible = false;
				PanelResult.Visible = true;
				APIResponse response = _WebService.GetBomComponents(user, password, custno, bomid);
				WriteResult(response, "Components");
			}
			catch (Exception oops)
			{
			}
			finally
			{
				//this.Enabled = true;
			}
		}

		// Inventory Changes
		protected void Button12_Click1(object sender, EventArgs e)
		{
			string user = TextBoxUser.Text;
			string password = TextBoxPassword.Text;
			string custno = TextBoxCustomer.Text;
			string daysInput = TextBoxDays.Text;
			int days = 0;

			TextBox1.Text = string.Empty;
			PanelPostOrder.Visible = false;
			PanelResult.Visible = true;
			TextBoxResult.Text = string.Empty;

			bool ok = int.TryParse(daysInput, out days);
			if (!ok)
			{
				TextBox1.Text = "Enter a number";
				return;
			}

			try
			{
				APIResponse response = _WebService.GetInventoryListChanges(user, password, custno, daysInput);
				WriteResult(response, "InventoryItems");
			}
			catch (Exception oops)
			{
			}
		}

		// Sales Order
		protected void Button13_Click1(object sender, EventArgs e)
		{
			string user = TextBoxUser.Text;
			string password = TextBoxPassword.Text;
			string custno = TextBoxCustomer.Text;
			string itemid = TextBoxItemId.Text;

			PanelPostOrder.Visible = false;
			PanelResult.Visible = true;

			try
			{
				APIResponse response = _WebService.GetRecommendedItems(user, password, custno, itemid);
				WriteResult(response, "InventoryItems");
			}
			catch (Exception oops)
			{
			}
		}

		// Tracking Number
		protected void Button14_Click1(object sender, EventArgs e)
		{
			string user = TextBoxUser.Text;
			string password = TextBoxPassword.Text;
			string custno = TextBoxCustomer.Text;
			string sono = TextBoxSono.Text;

			//this.Enabled = false;
			PanelPostOrder.Visible = false;
			PanelResult.Visible = true;
			TextBoxResult.Visible = true;

			try
			{
				APIResponse response = _WebService.GetSalesOrder(user, password, custno, sono);
				WriteResult(response, "SalesOrder");
			}
			catch (Exception oops)
			{
			}
			//this.Enabled = true;
		}

		// Post An Order
		protected void Button15_Click(object sender, EventArgs e)
		{
			string user = TextBoxUser.Text;
			string password = TextBoxPassword.Text;
			string custno = TextBoxCustomer.Text;
			string sono = TextBoxSono.Text;

			//this.Enabled = false;
			PanelPostOrder.Visible = false;
			PanelResult.Visible = true;
			TextBoxResult.Visible = true;

			try
			{
				APIResponse response = _WebService.GetTrackingNumber(user, password, custno, sono, "", "", "");
				WriteResult(response, "TrackingNumbers");
			}
			catch (Exception oops)
			{
			}
			//this.Enabled = true;
		}
	}
}